::/ https://discord.gg/Fy5bZXm4Z3 JOIN FOR MORE TOOLS
@echo off
mode con: cols=100 lines=20
color 0A
title Rec Room unlinker - By @so9a
chcp 65001 >nul
go to menu
net session >nul 2>&1
if %errorLevel% neq 0 (
    echo  [38;5;186 This script requires admin
    powershell -Command "Start-Process '%~f0' -Verb runAs"
    exit
)

:menu
cls
echo.
echo.
echo [38;5;213m  ██████╗ ██████╗ ███████╗██████╗  ██████╗  ██████╗ ███████╗███████╗██████╗ 
echo [38;5;177m  ██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝██╔════╝██╔══██╗
echo [38;5;141m  ██████╔╝██████╔╝███████╗██████╔╝██║   ██║██║   ██║█████╗  █████╗  ██████╔╝
echo [38;5;105m  ██╔══██╗██╔══██╗╚════██║██╔═══╝ ██║   ██║██║   ██║██╔══╝  ██╔══╝  ██╔══██╗
echo [38;5;69m  ██║  ██║██║  ██║███████║██║     ╚██████╔╝╚██████╔╝██║     ███████╗██║  ██║
echo [38;5;33m  ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝      ╚═════╝  ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝
echo. 
echo 	 [38;5;1419m ╔═══════════════════════╗    
echo 	 [38;5;141m https://discord.gg/UHaEMwHBff
echo 	         [38;5;218m ╚══════════════════════════════╝          
echo.
echo [38;5;213m ╔═══════════════════════════════╗
echo [38;5;177m ║ 1. Clean Rec Room files       ║                       
echo [38;5;141m ╚═══════════════════════════════╝
set /p choice= "═╝"
if "%choice%"=="1" goto clean
goto banner
:clean
cls
echo [-] Cleaning Rec Room files and registry entries...
echo [-] [38;5;75m Delete \AppData\LocalLow\Against Gravity
echo [-] [38;5;111m Delete \Temp\RecRoom
echo [-] [38;5;147m Delete \Temp\Against Gravity
echo [-] [38;5;183m Delete \Microsoft\Windows\Recent\RecRoom.lnk
echo [-] [38;5;219m Delete \Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url
del /q /f "C:\Users\%USERNAME%\AppData\LocalLow\Against Gravity" 2>nul
rd /s /q "%LocalAppData%\Temp\RecRoom" 2>nul
rd /s /q "%LocalAppData%\Temp\Against Gravity" 2>nul
del /q /f "%AppData%\Microsoft\Windows\Recent\RecRoom.lnk" 2>nul
del /q /f "%AppData%\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url" 2>nul

reg delete "HKEY_CURRENT_USER\Software\Against Gravity" /f 2>nul
reg delete "HKEY_CURRENT_USER\SOFTWARE\Classes\recroom" /f 2>nul
reg delete "HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710" /f 2>nul
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 471710" /f 2>nul

echo [-] [38;5;183m Delete HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 471710
echo [-] [38;5;111m Delete HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710
echo [-] [38;5;147m Delete HKEY_CURRENT_USER\SOFTWARE\Classes\recroom
echo [-] [38;5;75m Delete HKEY_CURRENT_USER\Software\Against Gravity
echo [+] [38;5;183m Delete Cleanup complete!
pause
goto menu

