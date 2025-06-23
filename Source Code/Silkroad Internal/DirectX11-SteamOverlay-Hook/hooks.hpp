#include "xorstr.hpp"
#include "features.hpp"
#include "natives.hpp"
#include <string>
#include "SteamOverlay.hpp"
#include "MinHook/MinHook.h"

#define _O(O) (O - 0x150000000)	//7									
#define _E(E) (E - 0x130000000)	//7								
#define _R(R) (R - 0x180000000)	//7									
#define _P(P) (P - 0x32000000)	//6

namespace SilkRoad
{
	void(*NOP_O)(DWORD*);
	void NOP_H(DWORD* __this)
	{
		return;
	}

	void(*NOP2_O)(DWORD*, DWORD*);
	void NOP2_H(DWORD* __this, DWORD* method)
	{
		return;
	}

	bool(*get_IsDeveloper_O)(DWORD*);
	bool get_IsDeveloper_H(DWORD* method)
	{
		if (EnableDev)
			return true;
		else
			return get_IsDeveloper_O(method);
	}

	bool(*get_IsFlyingEnabled_O)(DWORD*, DWORD*);
	bool get_IsFlyingEnabled_H(DWORD* Cock, DWORD* Balls)
	{
		if (DynamicFly)
			return true;
		else
			return get_IsFlyingEnabled_O(Cock, Balls);
	}

	void(*AddFlyEnabled_O)(DWORD*, bool, DWORD*, INT32, DWORD*);
	void AddFlyEnabled_H(DWORD* __this, bool enable, DWORD* token, INT32 priority, DWORD* method)
	{
		if (StaticFly)
			return AddFlyEnabled_O(__this, 1, token, priority, method);
		else
			return AddFlyEnabled_O(__this, enable, token, priority, method);
	}

	std::string* CreateString(const char* str)
	{
		static std::string* (*Create)(void* instance, const char* str, int* startIndex, int* length) =
			(std::string* (*)(void*, const char* str, int* startIndex, int* length))reinterpret_cast<void**>(GA + _E(0x136530C20));
		return Create(NULL, str, 0, (int*)strlen(str));
	}

	void (*SpawnConsumableForLocalPlayer_O)(DWORD*, std::string*, unsigned long*, Vector3, Quaternion, float, INT32*, DWORD*);
	void SpawnConsumableForLocalPlayer_H(DWORD* __this, std::string* string, unsigned long* longPrt, Vector3 Vec, Quaternion quat, float scale, INT32* BFDCKEJIDML, DWORD* method)
	{
		if (FoodSwap)
		{
			int foodcount = FoodInt;
			for (int i = 0; i < foodcount - 1; ++i)
			{
				SpawnConsumableForLocalPlayer_O(__this, CreateString(SelectedFood), longPrt, Vec, quat, FoodScale, BFDCKEJIDML, method);
			}
			SpawnConsumableForLocalPlayer_O(__this, CreateString(SelectedFood), longPrt, Vec, quat, FoodScale, BFDCKEJIDML, method);
		}
		else
		{
			int foodcount = FoodInt;
			for (int i = 0; i < foodcount - 1; ++i)
			{
				SpawnConsumableForLocalPlayer_O(__this, string, longPrt, Vec, quat, FoodScale, BFDCKEJIDML, method);
			}
			SpawnConsumableForLocalPlayer_O(__this, string, longPrt, Vec, quat, FoodScale, BFDCKEJIDML, method);
		}
	}

	void(*Fire_O)(DWORD*, Vector3, float, DWORD*);
	void Fire_H(DWORD* __this, Vector3 velocity, float charge, DWORD* Balls)
	{
		int Bullets = BulletAmount;
		for (int i = 0; i < Bullets - 1; ++i)
		{
			Fire_O(__this, velocity, charge, Balls);
		}
		return Fire_O(__this, velocity, charge, Balls);
	}

	void(*Set_Ammunition_O)(DWORD*, int32_t, int32_t, DWORD*);
	void Set_Ammunition_H(DWORD* __this, int32_t velocity, int32_t charge, DWORD* Balls)
	{
		if (InfiniteAmmo)
			return Set_Ammunition_O(__this, 1, 1, Balls);
		else
			return Set_Ammunition_O(__this, velocity, charge, Balls);
	}

	void(*RpcMasterAwardPoints_O)(DWORD*, Vector3, DWORD*, int32_t, bool, int32_t, bool, DWORD*);
	void RpcMasterAwardPoints_H(DWORD* __this, Vector3 Vec, DWORD* FCHEFMMPBJK, int32_t int1, bool bool1, int32_t int2, bool bool2, DWORD* method)
	{
		if (QuestPointsModifier)
			return RpcMasterAwardPoints_O(__this, Vec, FCHEFMMPBJK, QuestPointsInt, bool1, QuestPointsInt, bool2, method);
		else
			return RpcMasterAwardPoints_O(__this, Vec, FCHEFMMPBJK, QuestPointsInt, bool1, QuestPointsInt, bool2, method);
	}

	void(*RpcMasterRequestAddLootAllPlayers_O)(DWORD*, DWORD*, DWORD*, INT32, DWORD*);
	void RpcMasterRequestAddLootAllPlayers_H(DWORD* __this, DWORD* method, DWORD* tygYUH, INT32 Intt, DWORD* wdawd)
	{
		if (QuestGoldModifier)
			return RpcMasterRequestAddLootAllPlayers_O(__this, method, tygYUH, QuestGoldInt, wdawd);
		else
			return RpcMasterRequestAddLootAllPlayers_O(__this, method, tygYUH, Intt, wdawd);
	}

	bool(*get_IsLockedByKey_O)(DWORD*);
	bool get_IsLockedByKey_H(DWORD* Cock)
	{
		if (ForceGrabKeys)
			return true;
		else
			return get_IsLockedByKey_O(Cock);
	}

	bool(*get_IsOnCooldown_O)(DWORD*, DWORD*);
	bool get_IsOnCooldown_H(DWORD* __this, DWORD* method)
	{
		if (NoCoolDown)
			return false;
		else
			return get_IsOnCooldown_O(__this, method);
	}

	bool(*PlayerIsInvincible_O)(DWORD*, DWORD*, DWORD*);
	bool PlayerIsInvincible_H(DWORD* Cock, DWORD* And, DWORD* Balls)
	{
		if (QuestGodmode)
			return true;
		else
			return PlayerIsInvincible_O(Cock, And, Balls);
	}

	INT32(*GetCurrentGameplayRoomIndex_O)(DWORD*, DWORD*);
	INT32 GetCurrentGameplayRoomIndex_H(DWORD* __this, DWORD* method)
	{
		if (SkipGoldenTrophy) { return INT32(9); }
		else if (SkipCrims) { return INT32(9); }
		else if (SkipJumbotron) { return INT32(9); }
		else if (SkipIsle) { return INT32(7); }
		else if (SkipCresendo) { return INT32(12); }
		else if (SkipBoss) { return INT32(99); }
		else if (CustomSkip) { return INT32(CustomSkipper); }
		else
			return GetCurrentGameplayRoomIndex_O(__this, method);
	}

	void(*TryApplicationQuit2_O)(int32_t, DWORD*);
	void TryApplicationQuit2_H(int32_t __this, DWORD* method)
	{
		return;
	}

	void(*FatalApplicationQuit_O)(int32_t, std::string*, DWORD*);
	void FatalApplicationQuit_H(int32_t __this, std::string* huj, DWORD* method)
	{
		return;
	}

	void Hooks()
	{
		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x1314c40b0)), &get_IsFlyingEnabled_H, (void**)&get_IsFlyingEnabled_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x1314c40b0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x181C9ACF0)), &FatalApplicationQuit_H, (void**)&FatalApplicationQuit_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x181C9ACF0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x131CA50E0)), &TryApplicationQuit2_H, (void**)&TryApplicationQuit2_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x131CA50E0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x131CA4F60)), &NOP_H, (void**)&NOP_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x131CA4F60)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x131ca1790)), &NOP_H, (void**)&NOP_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x131ca1790)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x131ca16d0)), &NOP_H, (void**)&NOP_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x131ca16d0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _E(0x137D26D60)), &NOP2_H, (void**)&NOP2_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _E(0x137D26D60)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _O(0x157d26ef0)), &NOP2_H, (void**)&NOP2_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _O(0x157d26ef0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _O(0x1514b0b40)), &AddFlyEnabled_H, (void**)&AddFlyEnabled_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _O(0x1514b0b40)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _P(0x32cf5a20)), &SpawnConsumableForLocalPlayer_H, (void**)&SpawnConsumableForLocalPlayer_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _P(0x32cf5a20)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x1819caaa0)), &Set_Ammunition_H, (void**)&Set_Ammunition_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x1819caaa0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x1819BF2B0)), &Fire_H, (void**)&Fire_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x1819BF2B0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x181346F90)), &RpcMasterAwardPoints_H, (void**)&RpcMasterAwardPoints_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x181346F90)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x181993670)), &RpcMasterRequestAddLootAllPlayers_H, (void**)&RpcMasterRequestAddLootAllPlayers_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x181993670)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x1819c9810)), &get_IsOnCooldown_H, (void**)&get_IsOnCooldown_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x1819c9810)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _O(0x151c3abb0)), &PlayerIsInvincible_H, (void**)&PlayerIsInvincible_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _O(0x151c3abb0)));

		MH_CreateHook(reinterpret_cast<void**>(GA + _O(0x151344e50)), &GetCurrentGameplayRoomIndex_H, (void**)&GetCurrentGameplayRoomIndex_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _O(0x151344e50)));

		MH_CreateHook(reinterpret_cast<void**>(GA + 0x18099c0), &get_IsLockedByKey_H, (void**)&get_IsLockedByKey_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + 0x18099c0));

		MH_CreateHook(reinterpret_cast<void**>(GA + _R(0x181CA69B0)), &get_IsDeveloper_H, (void**)&get_IsDeveloper_O);
		MH_EnableHook(reinterpret_cast<void**>(GA + _R(0x181CA69B0)));
	}
}