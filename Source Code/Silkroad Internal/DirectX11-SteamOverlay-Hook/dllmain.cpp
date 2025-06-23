#include "includes.h"
#include <time.h>
#include "discord_rpc.h"
#include <thread>
#include <unordered_map>
#include "hooks.hpp"
#include "ui.hpp"
#include "ImGui/imgui_internal.h"
#include "AntiDebug.hpp"
#include <objbase.h>
#include <windows.h>
#include <iostream>
#include <string>
#include <ShlObj_core.h>

using namespace SilkRoad;
#define  IMGUI_DEFINE_MATH_OPERATORS

	HWND hWnd = NULL;
	Present oPresent = NULL;
	ID3D11Device* pDevice = NULL;
	ID3D11DeviceContext* pContext = NULL;
	ID3D11RenderTargetView* pRenderTargetView;
	WNDPROC oWndProc;
	bool Init = false;
	bool MenuOpen = false;
	bool InitHooks = false;
	std::string SessionID;
	std::string NewIV;

	extern LRESULT ImGui_ImplWin32_WndProcHandler(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);

	LRESULT WndProc(const HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
	{
		if (MenuOpen)
		{
			ImGui_ImplWin32_WndProcHandler(hWnd, uMsg, wParam, lParam);
			return 1;
		}
		else
		{
			return CallWindowProc(oWndProc, hWnd, uMsg, wParam, lParam);
		}
	}

	void UpdatePresence()
	{
		time_t start_time = time(nullptr);
		time_t elapsed_time = time(nullptr) - start_time;
		int hours = elapsed_time / 3600;
		int minutes = (elapsed_time % 3600) / 60;
		int seconds = elapsed_time % 60;
		DiscordRichPresence discordPresence;
		memset(&discordPresence, 0, sizeof(discordPresence));
		discordPresence.startTimestamp = start_time;
		discordPresence.state = "discord.gg/SilkRoadV2 Cheapest Rec Room Client!"; // Added this on to the string because it was 
		discordPresence.details = "--Rec Room Client";
		discordPresence.largeImageKey = "12";
		discordPresence.largeImageText = "Cheapest Rec Room Client!";
		Discord_UpdatePresence(&discordPresence);
	}

	void SetStyles()
	{
		ImGuiStyle& style = ImGui::GetStyle();
		ImGui::GetStyle().SelectableTextAlign = ImVec2(0.5f, 0.5f);
		ImGui::GetStyle().WindowRounding = 1.2f;
		ImGui::GetStyle().WindowBorderSize = 1.2f;
		ImGui::GetStyle().ChildRounding = 1.2f;

		ImVec4* colors = ImGui::GetStyle().Colors;
		colors[ImGuiCol_FrameBg] = ImGui::ColorConvertU32ToFloat4(ImColor(0, 0, 0, 190));
		colors[ImGuiCol_Border] = ImGui::ColorConvertU32ToFloat4(ImColor(145, 0, 0, 255));
		colors[ImGuiCol_CheckMark] = ImGui::ColorConvertU32ToFloat4(ImColor(145, 0, 0, 255));
		colors[ImGuiCol_SliderGrab] = ImGui::ColorConvertU32ToFloat4(ImColor(145, 0, 0, 255));

		ImFontConfig font_config;
		font_config.PixelSnapH = false;
		font_config.FontDataOwnedByAtlas = false;
		font_config.OversampleH = 5;
		font_config.OversampleV = 5;
		font_config.RasterizerMultiply = 1.2f;

		static const ImWchar ranges[] = {

			0x0020, 0x00FF,
			0x0400, 0x052F,
			0x2DE0, 0x2DFF,
			0xA640, 0xA69F, 
			0xE000, 0xE226,
			0,
		};

		font_config.GlyphRanges = ranges;
		ImGuiIO& io = ImGui::GetIO();
		io.Fonts->AddFontFromFileTTF(_("C:\\Windows\\Fonts\\tahoma.ttf"), 18, &font_config, ranges);
		io.ConfigFlags = ImGuiConfigFlags_NoMouseCursorChange;

		ImGui::GetStyle().SelectableTextAlign = ImVec2(0.5f, 0.5f);
		ImGui::GetStyle().WindowRounding = 1.2f;
		ImGui::GetStyle().WindowBorderSize = 1.2f;
		ImGui::GetStyle().ChildRounding = 1.2f;

		PushStyleVar(ImGuiStyleVar_WindowPadding, ImVec2(0, 0));
		PushStyleVar(ImGuiStyleVar_WindowMinSize, ImVec2(510, 380));

	}

	void ToolTip(const char* Text)
	{
		if (ImGui::IsItemHovered())
		{
			ImGui::SetTooltip(Text);
		}
	}

	void InitImGui()
	{
		ImGuiIO& io = ImGui::GetIO();
		SetStyles();
		ImGui::StyleColorsDark();
	}

	void Player()
	{
		custom.begin_child(_("Player"), ImVec2(GetWindowWidth() / 2 - GetStyle().ItemSpacing.x + 360, GetWindowHeight()));
		{
			ImGui::Spacing();
			Checkbox(_("[Static] Fly"), &StaticFly);
			Checkbox(_("[Dynamic] Fly"), &DynamicFly);
			ImGui::Spacing();
			Checkbox(_("Dev Features"), &EnableDev);
		} custom.end_child();
	}

	void Weapon()
	{
		custom.begin_child(_("Weapon"), ImVec2(GetWindowWidth() / 2 - GetStyle().ItemSpacing.x + 360, GetWindowHeight()));
		{
			ImGui::Spacing();
			ImGui::Checkbox(_("Infinite Ammo"), &InfiniteAmmo);
			ImGui::Checkbox(_("No Cooldown"), &NoCoolDown);
			ImGui::Spacing();
			ImGui::Text(_("-Modifiers"));
			ImGui::SliderInt(_("Bullet Amount"), &BulletAmount, 1, 1000);
			ImGui::Spacing();
		} custom.end_child();
	}

	void Quest()
	{
		custom.begin_child(_("##Quest"), ImVec2(GetWindowWidth() / 2 - GetStyle().ItemSpacing.x + 360, GetWindowHeight()));
		{
			if (ImGui::BeginTabBar(_("##TabBar2")))
			{
				if (ImGui::BeginTabItem(_("Quest Modifiers")))
				{
					ImGui::Checkbox(_("Points Multipler"), &QuestPointsModifier);
					ImGui::SameLine();
					ImGui::SliderInt(_("##Points"), &QuestPointsInt, 1, 100000);
					ImGui::Checkbox(_("Gold/Silver Multipler"), &QuestGoldModifier); ToolTip(_("Beware Of The Gold And Silver Limit!"));
					ImGui::SameLine();
					ImGui::SliderInt(_("##Amount"), &QuestGoldInt, 1, 100000);
					ImGui::EndTabItem();
				}
				if (ImGui::BeginTabItem(_("Enemy Settings")))
				{
					ImGui::Checkbox(_("No Damage To Players"), &QuestGodmode);
					ImGui::EndTabItem();
				}
				if (ImGui::BeginTabItem(_("Quest Skips")))
				{
					ImGui::Text(_("-Make Sure To Disable When Loaded In Boss Room!-"));
					ImGui::Checkbox(_("Golden Trophy"), &SkipGoldenTrophy);
					ImGui::Checkbox(_("Crimson Cauldron"), &SkipCrims);
					ImGui::Checkbox(_("Jumbotron"), &SkipJumbotron);
					ImGui::Checkbox(_("Isle Of Lost Skulls"), &SkipIsle);
					ImGui::Checkbox(_("Cresendo"), &SkipCresendo);;
					ImGui::Checkbox(_("Skip Boss"), &SkipBoss);
					ImGui::Checkbox(_("Custom Skip"), &CustomSkip);
					ImGui::SameLine();
					if (CustomSkip)
						ImGui::SliderInt(_("Rooms To Skip"), &CustomSkipper, 1, 99);
					ImGui::EndTabItem();
				}
			}
		} custom.end_child();
	}

	void Misc()
	{
		custom.begin_child(_("##Misc"), ImVec2(GetWindowWidth() / 2 - GetStyle().ItemSpacing.x + 360, GetWindowHeight()));
		{
			if (ImGui::BeginTabBar(_("##TabBar5")))
			{
				if (ImGui::BeginTabItem(_("Food Settings")))
				{
					ImGui::SliderInt(_("Food Amount"), &FoodInt, 1, 1000); ImGui::SameLine(); if (ImGui::Button("Reset")) { FoodInt = 1; }
					ImGui::SliderFloat(_("Food Scale"), &FoodScale, 0.1, 99.); ImGui::SameLine(); if (ImGui::Button("Reset")) { FoodScale = 1.0f; }
					ImGui::Spacing();
					ImGui::Spacing();
					ImGui::Checkbox(_("Enable Food Swap"), &FoodSwap);
					ImGui::InputText(_("Search"), searchBuffer, IM_ARRAYSIZE(searchBuffer));
					for (int i = 0; i < ARRAYSIZE(Guid); i++)
					{
						if (strlen(searchBuffer) > 0 && strstr(Guid[i].frie, searchBuffer) == nullptr)
							continue;
						bool isSelected = (SelectedFood == Guid[i].guid);
						if (ImGui::Selectable(Guid[i].frie, isSelected))
						{
							SelectedFood = Guid[i].guid;
						}
					}
					ImGui::EndTabItem();
				}
				if (ImGui::BeginTabItem(_("Other")))
				{
					if (ImGui::Button(_("Set Time Scale"))) { SetTimeScale(TimeScale); } ImGui::SameLine();
					if (ImGui::Button(_("Reset"))) { SetTimeScale(1.f); TimeScale = 1.; }
					ImGui::SliderFloat(_("Time"), &TimeScale, 0.1, 99.);
				}
				ImGui::EndTabBar();
			}
			ImGui::Spacing();
		} custom.end_child();
	}

	void Settings()
	{
		custom.begin_child(_("Settings"), ImVec2(GetWindowWidth() / 2 - GetStyle().ItemSpacing.x + 360, GetWindowHeight()));
		{
			ImGui::Spacing();
			ImGui::Checkbox(_("Show Playing On Discord"), &EnableDiscord);
			ImGui::Spacing();
		} custom.end_child();
	}

	HRESULT hkPresent(IDXGISwapChain* pSwapchain, UINT SyncInterval, UINT Flags)
	{
		if (!Init) 
		{
			if (SUCCEEDED(pSwapchain->GetDevice(__uuidof(ID3D11Device), (void**)&pDevice))) 
			{
				pDevice->GetImmediateContext(&pContext);
				DXGI_SWAP_CHAIN_DESC sd;
				pSwapchain->GetDesc(&sd);
				hWnd = sd.OutputWindow;
				ID3D11Texture2D* pBackBuffer;
				pSwapchain->GetBuffer(0, __uuidof(ID3D11Texture2D), (LPVOID*)&pBackBuffer);
				pDevice->CreateRenderTargetView(pBackBuffer, NULL, &pRenderTargetView);
				pBackBuffer->Release();
				oWndProc = (WNDPROC)SetWindowLongPtr(hWnd, GWLP_WNDPROC, (LONG_PTR)WndProc);
				ImGui::CreateContext();
				ImGuiIO& io = ImGui::GetIO();
				io.ConfigFlags = ImGuiConfigFlags_NoMouseCursorChange;
				ImGui_ImplWin32_Init(hWnd);
				ImGui_ImplDX11_Init(pDevice, pContext);
				InitImGui();
				Init = true;
			}
			else return oPresent(pSwapchain, SyncInterval, Flags);
		}

		ImGui_ImplDX11_NewFrame();
		ImGui_ImplWin32_NewFrame();
		ImGui::NewFrame();

		if (GetAsyncKeyState(VK_INSERT) & 1)
			MenuOpen = !MenuOpen;

		if (MenuOpen)
		{
			ImGui::GetIO().WantCaptureMouse = 1;
			ImGui::GetIO().MouseDrawCursor = 1;
		}
		else
		{
			ImGui::GetIO().WantCaptureMouse = 0;
			ImGui::GetIO().MouseDrawCursor = 0;
		}

		if (MenuOpen)
		{
			ImGui::Begin(_("##main"), NULL, ImGuiWindowFlags_NoTitleBar | ImGuiWindowFlags_NoScrollbar | ImGuiWindowFlags_NoCollapse | ImGuiWindowFlags_NoResize);
			{
				ImGui::SetWindowSize(ImVec2(793, 513));
				auto window = ImGui::GetCurrentWindow();
				auto draw = window->DrawList;
				ImVec2 pos = window->Pos;
				ImVec2 size = window->Size;
				custom.m_anim = ImLerp(custom.m_anim, 1.f, 0.03f);
				draw->AddLine(pos + ImVec2(40, 40), pos + ImVec2(size.x - 15, 40), ImColor(1.f, 1.f, 1.f, 0.05f));
				SetCursorPos(ImVec2(231, 10));
				ImGui::BeginGroup();
				for (int i = 0; i < custom.rage_subtabs.size(); ++i)
				{
					if (custom.sub_tab(custom.rage_subtabs.at(i), custom.m_rage_subtab == i) && custom.m_rage_subtab != i)
						custom.m_rage_subtab = i, custom.m_anim = 0.f;
					if (i != custom.rage_subtabs.size() - 1)
						SameLine();
				}
				ImGui::EndGroup();
				SetCursorPos(ImVec2(40, 50));
				ImGui::BeginChild(_("##childs"), ImVec2(GetWindowWidth() - 80, GetWindowHeight() - 80));
				{
					switch (custom.m_rage_subtab)
					{
					case 0:
						Player();
						break;
					case 1:
						Weapon();
						break;
					case 2:
						Quest();
						break;
					case 3:
						Misc();
						break;
					case 4:
						Settings();
						break;
					}
				}
				ImGui::EndChild();
				draw->AddRectFilled(pos + ImVec2(0, size.y - 20), pos + size, ImColor(15, 14, 21), ImGui::GetStyle().WindowRounding, ImDrawFlags_RoundCornersBottom);
				draw->AddText(pos + ImVec2(5, size.y - 18), ImGui::GetColorU32(ImGuiCol_Text), _("SilkRoad Cheats"));
				draw->AddText(pos + ImVec2(size.x - CalcTextSize(_("By Silkroad Team")).x - 5, size.y - 18), GetColorU32(ImGuiCol_Text), _("By Silkroad Team"));
			}
			ImGui::End();
		}
		ImGui::SetNextWindowPos(ImVec2(10, 10), ImGuiCond_Always);
		ImGui::SetWindowSize(ImVec2(445, 30));
		ImGui::PushStyleVar(ImGuiStyleVar_WindowRounding, 10.0f);
		ImGui::PushStyleColor(ImGuiCol_WindowBg, ImVec4(0, 0, 0, 0.8f));

		ImGui::Begin("Credits", nullptr,
			ImGuiWindowFlags_NoResize | ImGuiWindowFlags_NoCollapse |
			ImGuiWindowFlags_NoTitleBar | ImGuiWindowFlags_NoMove);

		float time = ImGui::GetTime();
		float baseHue = fmod(time * 0.8f, 1.0f);
		const char* creditsText = "Silkroad | Version 2.5 | Okamxu & PotatoIsCool | ";
		for (int i = 0; i < strlen(creditsText); i++)
		{
			float hue = fmod(baseHue + i * 0.02f, 1.0f);
			ImVec4 color = ImColor::HSV(hue, 0.85f, 1.0f);
			char charStr[2] = { creditsText[i], '\0' };
			ImGui::TextColored(color, "%s", charStr);
			ImGui::SameLine(0.0f, 0.0f);
		}

		float fpsHue = fmod(time * 0.8f, 1.0f);
		ImVec4 fpsColor = ImColor::HSV(fpsHue, 0.9f, 1.0f);
		ImGui::SameLine();
		ImGui::TextColored(fpsColor, "%.1f FPS", ImGui::GetIO().Framerate);

		ImGui::End();
		ImGui::PopStyleVar();
		ImGui::PopStyleColor();
		ImGui::EndFrame();
		ImGui::Render();
		pContext->OMSetRenderTargets(1, &pRenderTargetView, NULL);
		ImGui_ImplDX11_RenderDrawData(ImGui::GetDrawData());
		return oPresent(pSwapchain, SyncInterval, Flags);
	}

bool setTempDirectory()
{ 
	char tempPath[MAX_PATH];
	if (GetTempPathA(MAX_PATH, tempPath) == 0)
	{
		return false;
	}
	if (SetCurrentDirectoryA(tempPath))
	{
		return true;
	}
	return false;
}

bool setCurrentDirectoryToFolderInDocuments()
{
	char documentsPath[MAX_PATH];
	if (SHGetSpecialFolderPathA(NULL, documentsPath, CSIDL_PERSONAL, FALSE) == 0)
	{
		return false;
	}
	std::string folderPath = std::string(documentsPath) + _("\\") + _("SilkRoad");
	if (CreateDirectoryA(folderPath.c_str(), NULL) || GetLastError() == ERROR_ALREADY_EXISTS)
	{
		if (SetCurrentDirectoryA(folderPath.c_str()))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	else
	{
		return false;
	}
}

std::string getLicenseKeyFromFile()
{
	setCurrentDirectoryToFolderInDocuments();
	std::ifstream file(_("license.key"));
	std::string licenseKey;
	if (file.is_open()) {
		std::getline(file, licenseKey);
		file.close();
	}
	return licenseKey;
}


void STDMETHODCALLTYPE MainThread()
{
	MH_Initialize();
	MH_CreateHook(reinterpret_cast<void**>(RRDLL + _O(0x152F2AC10)), &NOP2_H, (void**)&NOP2_O);
	MH_EnableHook(reinterpret_cast<void**>(RRDLL + _O(0x152F2AC10)));
	MH_CreateHook(reinterpret_cast<void**>(PatternScan::FindPattern(PatternScan::GetSteamModule(), _("48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 57 41 56 41 57 48 83 EC ? 41 8B E8"))), &hkPresent, (void**)&oPresent);
	MH_EnableHook(reinterpret_cast<void**>(PatternScan::FindPattern(PatternScan::GetSteamModule(), _("48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 57 41 56 41 57 48 83 EC ? 41 8B E8"))));
	Hooks();
	if (EnableDiscord)
	{
		DiscordEventHandlers Handle;
		memset(&Handle, 0, sizeof(Handle));
		Discord_Initialize(_("1340210457025445928"), &Handle, 1, NULL);
		UpdatePresence();
	}
}


//if (AllocConsole())
//{
//	FILE* pFile = nullptr;
//	freopen_s(&pFile, "CONOUT$", "w", stdout);
//	freopen_s(&pFile, "CONIN$", "r", stdin); 
//	freopen_s(&pFile, "CONERR$", "w", stderr);
//}


BOOL APIENTRY DllMain(HMODULE hModule, DWORD dwReason, LPVOID lpReserved)
{
	if (dwReason == DLL_PROCESS_ATTACH)
	{
		DisableThreadLibraryCalls(hModule);
		//std::string GetK = getLicenseKeyFromFile();

		//if (!GetK.empty())
		//{
			MainThread();
		//}
		//else
		//{
		//	initiateDetection();
		//}
	}

	return TRUE;
}