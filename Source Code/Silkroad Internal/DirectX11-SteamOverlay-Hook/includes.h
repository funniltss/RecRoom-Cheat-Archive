#pragma once
#include <Windows.h>
#include <vector>
#include <d3d11.h>
#include "SteamOverlay.hpp"
typedef HRESULT(*Present)(IDXGISwapChain*, UINT, UINT);
typedef LRESULT(CALLBACK* WNDPROC)(HWND, UINT, WPARAM, LPARAM);

struct Vector3 {
	float x;
	float y;
	float z;
};

struct Quaternion {
	float x;
	float y;
	float z;
	float w;
};