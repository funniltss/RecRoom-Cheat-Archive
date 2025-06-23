#include <string>
#include "xorstr.hpp"

#define _L(L) (L - 0x780000000)

uintptr_t UESTS = _L(0x788c019e0);

typedef struct Food
{
	const char* frie;
	const char* guid;
} Food;

Food Guid[]
{
	{ "87 Flavor Cake", "xwQWBB_fekmTqRc2LB92cg" },
	{ "Assorted Donuts", "ZuvkidodzkuOfGLDnTOFyg" },
	{ "Bubble Tea", "JxAl1wVJ1UGAjoT3m3ilug" },
	{ "Bubbly Classic", "iiGTvhOCHkOTNJhb16Zbyw" },
	{ "Cake Pops", "Efd3_dy4ZEqWr7i6j5x0aA" },
	{ "Candy Apples", "EmPvh3I6L0uK_1i8Wy_ylQ" },
	{ "Celebration Cake", "Sk_1sm88ZU2zpWn01Lv7hw" },
	{ "Cheese Pizza", "5hIAZ9wg5EyG1cILf4FS2A" },
	{ "Chocolate Cake", "BbJb1_0g4EGJP_CeNrjpew" },
	{ "Chocolate Frosted Donuts", "mMCGPgK3tki5S_15q2Z81A" },
	{ "Chocolate Popcorn", "lWN_g4OcN0S0C4n6cSZq4g" },
	{ "Chocolate Variety Box", "K9RbXo-4U0q6NbGu8VL1Sw" },
	{ "Classic Popcorn", "QRx0aSTT9keMFdAJMQHdTg" },
	{ "Creator Bubbly", "KFd3wxfnfUybCVkfj1pz1A" },
	{ "Dessert Pizza", "3Z-9qU4n2EuNRzRNl_pqcA" },
	{ "Flaming Popcorn", "uswFSANaZES0EJMLfOgNSw" },
	{ "Forbidden Bubbly", "6F-kHEhKp0-jYli7fP5yIQ" },
	{ "Forsaken Bubbly", "F4SOI0n8k0eo21jvbxsERA" },
	{ "Glazed Donuts", "7OZ5AE3uuUyqa0P-2W1ptg" },
	{ "Hackkola", "A3BTx10GqESuq22C-4M27w" },
	{ "Hawaiian Pizza", "_jnjYGBcyEWY5Ub4OezXcA" },
	{ "Hot Chocolate", "JwlQox0EUEi0yJSJlJ7-pg" },
	{ "Invasion Donuts", "-_VNAj3P10aWCCJZoVTF4Q" },
	{ "Latte", "P15H1ONBhk-5DYYjid1ttg" },
	{ "Midnight Gala Bubbly", "s4dX5dfMM0OX9TSuDzLVXg" },
	{ "Pastel Cake", "TG_VYTUdvkeT6zG6o1yZlw" },
	{ "Pepperoni Pizza", "mq23W-RSP0G8iGNLdrcpUw" },
	{ "Premium Bubbly", "4TGctDRPiE2GWiP3CKQqLw" },
	{ "Pumpkin Spice Latte", "4v65OqJc0EGzry_taWKzNA" },
	{ "Rec-Con Bubbly v1", "YNaldB09Kk2kiWVzrmNUGQ" },
	{ "Rec-Con Bubbly v2", "hUfeoD0ESUitHLG7juSqmA" },
	{ "Red Apples", "uMHrUPLYFk2rJOW_uop5Aw" },
	{ "Red Velvet Cake", "LwaotjVEBUir0-w8126n_g" },
	{ "Root Beer", "JfnVXFmilU6ysv-VbTAe3A" },
	{ "Salted Pretzels", "InQ25wQMGkG_bvuD5rf2Ag" },
	{ "Snowman Donuts", "jdrRJ7deWk2P9aRRrPy3zw" },
	{ "Sparklers", "hRdK6NGfAkGBmYSs_xGzXg" },
	{ "Supreme Pizza", "wUCIKdJSvEmiQHYMyx4X4w" },
	{ "Surve Bubbly v1", "bN7kzl_F2E-U2iWE_3m0Aw" },
	{ "Surve Bubbly v2", "kP6U6RYXf0yhEGhIFz7T7g" },
	{ "Surve Bubbly v3", "FivdMXwHk2eMhmngMB8yA" },
	{ "Sushi", "4My42w1D1Uu3-98pXB-x_Q" },
	{ "VR Cola", "YpL6eN6sKEquOYIYnbhvew" }
};

const char* SelectedFood;
int FoodF = sizeof(Guid) / sizeof(Guid[0]);

namespace SilkRoad
{
	uintptr_t GA = (uintptr_t)GetModuleHandleA(_("GameAssembly.dll"));
	uintptr_t RRDLL = (uintptr_t)GetModuleHandleA(_("RecRoom.exe.dll"));
	uintptr_t UE = (uintptr_t)GetModuleHandleA(_("UnityEngine.dll"));

	// Sorted these so its easier to read
	static char searchBuffer[64] = "";
	float BulletSpeed = 1;
	float SetFOV = 1;
	float FoodScale = 1;
	float TPDistance = 1;
	float TimeScale = 1;
	int FoodInt = 1;
	int CustomSkipper = 1;
	int BulletAmount = 1;
	int QuestPointsInt = 1;
	int QuestGoldInt = 1;
	bool DynamicFly = false;
	bool StaticFly = false;
	bool FoodSettings = false;
	bool FoodSwap = false;
	bool NoTPCooldown = false;
	bool InfiniteAmmo = false;
	bool EnableTPDistance = false;
	bool DisableEveryonesPickups = false;
	bool InstantRespawn = false;
	bool QuestGodmode = false;
	bool NoCoolDown = false;
	bool EnableDev = false;
	bool EnableDiscord = true;
	bool SkipGoldenTrophy = false;
	bool SkipCrims = false;
	bool SkipJumbotron = false;
	bool SkipIsle = false;
	bool SkipCresendo = false;
	bool SkipBoss = false;
	bool BulletToggle = false;
	bool QuestPointsModifier = false;
	bool ForceGrabKeys = false;
	bool CustomSkip = false;
	bool QuestGoldModifier = false;
	bool EnableFov = false;
	bool ToolScaleBool = false;


	void SetTimeScale(float Scale)
	{
		typedef void(__fastcall* SetTimeScale)(float, DWORD*);
		SetTimeScale timeScale = reinterpret_cast<SetTimeScale>(GA + UESTS);
		timeScale(Scale, nullptr);
	}
}