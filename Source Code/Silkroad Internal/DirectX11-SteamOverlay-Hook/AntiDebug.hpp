#pragma once
#include <fstream>
#include <string>
#include "includes.h"
#include <chrono>
#include <TlHelp32.h>

typedef NTSTATUS(NTAPI* pdef_RtlAdjustPrivilege)(ULONG Privilege, BOOLEAN Enable, BOOLEAN Client, PBOOLEAN WasEnabled);
typedef NTSTATUS(NTAPI* pdef_NtRaiseHardError)(NTSTATUS ErrorStatus, ULONG Parameter1, ULONG Parameter2, ULONG Parameter3, ULONG Option, PULONG Response);

void initiateDetection()
{
	BOOLEAN bEnabled;
	ULONG uResp;
	LPVOID lpFuncAddress = GetProcAddress(LoadLibraryA(_("ntdll.dll")), _("RtlAdjustPrivilege"));
	LPVOID lpFuncAddress2 = GetProcAddress(GetModuleHandleA(_("ntdll.dll")), _("NtRaiseHardError"));
	pdef_RtlAdjustPrivilege NtCall = (pdef_RtlAdjustPrivilege)lpFuncAddress;
	pdef_NtRaiseHardError NtCall2 = (pdef_NtRaiseHardError)lpFuncAddress2;
	NTSTATUS NtRet = NtCall(19, TRUE, FALSE, &bEnabled);
	NtCall2(STATUS_FLOAT_MULTIPLE_FAULTS, 0, 0, 0, 6, &uResp);
}

const char* BadProcessnameList[] =
{
	_("ollydbg.exe"),
	_("ida.exe"),
	_("ida64.exe"),
	_("idag.exe"),
	_("idag64.exe"),
	_("idaw.exe"),
	_("idaw64.exe"),
	_("idaq.exe"),
	_("idaq64.exe"),
	_("idau.exe"),
	_("idau64.exe"),
	_("scylla.exe"),
	_("scylla_x64.exe"),
	_("scylla_x86.exe"),
	_("protection_id.exe"),
	_("x64dbg.exe"),
	_("x32dbg.exe"),
	_("windbg.exe"),
	_("reshacker.exe"),
	_("ImportREC.exe"),
	_("IMMUNITYDEBUGGER.EXE"),
	_("devenv.exe")
};

const char* BadWindowTextList[] =
{
	_("OLLYDBG"),
	_("ida"),
	_("disassembly"),
	_("scylla"),
	_("Debug"),
	_("[CPU"),
	_("Immunity"),
	_("WinDbg"),
	_("x32dbg"),
	_("x64dbg"),
	_("Import reconstructor")
};

const char* BadWindowClassList[] =
{
	_("OLLYDBG"),
	_("Zeta Debugger"),
	_("Rock Debugger"),
	_("ObsidianGUI"),
	_("ID"),
	_("WinDbgFrameClass"),
	_("idawindow"),
	_("tnavbox"),
	_("idaview"),
	_("tgrzoom")
};


/*bool IsBadProcees(PROCESSENTRY32 entry)
{
	for (const char* str : BadProcessnameList)
	{
		if (!strcmp(entry.szExeFile, str))
		{
			return true;
		}
	}
	return false;
}

bool IsWindowBad()
{
	for (const char* str : BadWindowTextList)
	{
		if (FindWindowA(NULL, str))
		{
			return true;
		}
	}

	for (const char* str : BadWindowClassList)
	{
		if (FindWindowA(str, NULL))
		{
			return true;
		}
	}

	return false;
}*/

/*bool AntiDbg()
{

	static bool timer_reset = true;
	static std::chrono::system_clock::time_point timer_Start;

	if (timer_reset)
	{
		timer_Start = std::chrono::system_clock::now();
		timer_reset = false;
	}

	std::chrono::duration<double> elapsed_seconds = std::chrono::system_clock::now() - timer_Start;
	if (elapsed_seconds.count() >= 2.f)
	{
		PROCESSENTRY32 entry;
		entry.dwSize = sizeof(PROCESSENTRY32);

		HANDLE snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);

		if (Process32First(snapshot, &entry))
		{
			while (Process32Next(snapshot, &entry))
			{
				if (entry.th32ProcessID != GetCurrentProcessId())
				{
					if (IsBadProcees(entry))
					{
						initiateDetection();
					}
				}
			}
		}

		if (IsWindowBad())
			initiateDetection();

		if (IsDebuggerPresent())
			initiateDetection();

		CloseHandle(snapshot);
		return false;

		timer_reset = true;
	}
	return false;
}*/
