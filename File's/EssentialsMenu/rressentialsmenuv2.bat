@echo off
mode con: cols=100 lines=20
color 0A
title Rec Room Utilities
chcp 65001 >nul

:: Launches the Python script for Discord status
start "" pythonw "%~dp0status.py"

:: Starts the F8 Toggle script
start "" "%~dp0Extras\FocusToggle.ahk"

:menu
cls
echo.
echo.
echo [38;5;69m ╔═══════════════════════════════╗
echo [38;5;69m ║    Rec Room Utilities Menu    ║ 
echo [38;5;69m ╚═══════════════════════════════╝
echo.
echo [38;5;33m ╔═══════════════════════════════╗
echo [38;5;69m ║ 1. Clean Rec Room files       ║
echo [38;5;141m ║ 2. Launch Rec Room (Launcher) ║
echo [38;5;105m ║ 3. Launch Rec Room (Steam)    ║
echo [38;5;177m ║ 4. Open RecNet                ║
echo [38;5;213m ║ 5. Access Bearer Token Site   ║
echo [38;5;218m ║ 6. Force Exit Rec Room        ║
echo [38;5;228m ║ 7. Go to Page 2               ║
echo [38;5;218m ║ 8. Exit                       ║
echo [38;5;218m ╚═══════════════════════════════╝
set /p choice= "═╝ "
if "%choice%"=="1" goto clean
if "%choice%"=="2" goto launcher
if "%choice%"=="3" goto steam
if "%choice%"=="4" goto open_recnet
if "%choice%"=="5" goto bearer_token
if "%choice%"=="6" goto force_exit
if "%choice%"=="7" goto page2
if "%choice%"=="8" goto minimize_program
goto menu

:clean
cls
echo.
echo.
echo [38;5;69m ╔═══════════════════════════════╗
echo [38;5;69m ║    Rec Room Utilities Menu    ║
echo [38;5;69m ╚═══════════════════════════════╝
echo.
echo [38;5;33m ╔═══════════════════════════════╗
echo [38;5;69m ║ 1. Clean Rec Room files       ║
echo [38;5;141m ║ 2. Launch Rec Room (Launcher) ║
echo [38;5;105m ║ 3. Launch Rec Room (Steam)    ║
echo [38;5;177m ║ 4. Open RecNet                ║
echo [38;5;213m ║ 5. Access Bearer Token Site   ║
echo [38;5;218m ║ 6. Exit                       ║
echo [38;5;218m ╚═══════════════════════════════╝
set /p choice= "═╝ "
if "%choice%"=="1" goto clean
if "%choice%"=="2" goto launcher
if "%choice%"=="3" goto steam
if "%choice%"=="4" goto open_recnet
if "%choice%"=="5" goto bearer_token
if "%choice%"=="6" exit
goto menu

:clean
cls
echo [-] Cleaning Rec Room files and registry entries...
echo [-] [38;5;75m Deleting \AppData\LocalLow\Against Gravity
echo [-] [38;5;111m Deleting \Temp\RecRoom
echo [-] [38;5;147m Deleting \Temp\Against Gravity
echo [-] [38;5;183m Deleting \Microsoft\Windows\Recent\RecRoom.lnk
echo [-] [38;5;219m Deleting \Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url
del /q /f "C:\Users\%USERNAME%\AppData\LocalLow\Against Gravity" 2>nul
rd /s /q "%LocalAppData%\Temp\RecRoom" 2>nul
rd /s /q "%LocalAppData%\Temp\Against Gravity" 2>nul
del /q /f "%AppData%\Microsoft\Windows\Recent\RecRoom.lnk" 2>nul
del /q /f "%AppData%\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url" 2>nul

reg delete "HKEY_CURRENT_USER\Software\Against Gravity" /f 2>nul
reg delete "HKEY_CURRENT_USER\SOFTWARE\Classes\recroom" /f 2>nul
reg delete "HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710" /f 2>nul
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 471710" /f 2>nul

echo [+] Cleanup complete!
pause
goto menu

:launcher
cls
echo Launching Rec Room (Launcher)...
start "" "C:\Users\%USERNAME%\AppData\Local\Programs\recroom-launcher\Apps\Rec Room\Recroom_WindowsPlatformless"
pause
goto menu

:steam
cls
echo [38;5;205m Launching Rec Room (Steam)...
for %%D in (C D E F G H I J K L M N O P Q R S T U V W X Y Z) do (
    if exist "%%D:\SteamLibrary\steamapps\common\RecRoom\RecRoom_Release.exe" (
        echo [38;5;141m Steam version found! Launching now...
        start "" "%%D:\SteamLibrary\steamapps\common\RecRoom\RecRoom_Release.exe"
        pause
        goto menu
    )
)
echo [38;5;177m Steam version not found on available drives.
pause
goto menu
	

:open_recnet
cls
echo Opening RecNet in your default browser...
start "" "https://rec.net"
pause
goto menu

:bearer_token
cls
echo Accessing Bearer Token Site in your default browser...
start "" "https://rec.net/api/auth/session"
pause
goto menu

:force_exit
cls
echo Force Exiting Rec Room...
taskkill /f /im recroom.exe
pause
goto menu

:page2
cls
echo.
echo.
echo [38;5;69m ╔═══════════════════════════════╗
echo [38;5;69m ║          Page 2 Menu          ║
echo [38;5;69m ╚═══════════════════════════════╝
echo.
echo [38;5;33m ╔═══════════════════════════════╗
echo [38;5;69m ║ 1. Launch Backpack Spawner    ║
echo [38;5;141m ║ 2. Launch Clumsy              ║
echo [38;5;177m ║ 3. Launch AntiKick            ║
echo [38;5;218m ║ 4. Launch Username Checker    ║
echo [38;5;183m ║ 5. Launch Infinite Timestop   ║
echo [38;5;228m ║ 6. Return to Main Menu        ║
echo [38;5;218m ╚═══════════════════════════════╝
set /p choice2= "═╝ "
if "%choice2%"=="1" goto backpack_spawner
if "%choice2%"=="2" goto clumsy
if "%choice2%"=="3" goto antikick
if "%choice2%"=="4" goto username_checker
if "%choice2%"=="5" goto infinite_timestop
if "%choice2%"=="6" goto menu
goto page2

:infinite_timestop
cls
echo Launching Infinite Timestop Program...
start "" "%~dp0Infinite Timestop\Citra.exe"
pause
goto page2

:username_checker
cls
echo Launching Username Checker...
start "" "python.exe" "%~dp0RecTools Username Checker\Username Checker.py"
pause
goto page2

:backpack_spawner
cls
echo Launching Backpack Spawner as Administrator...
powershell -Command "Start-Process '%~dp0Backpack\Backpack Spawner.exe' -Verb RunAs"
pause
goto page2

:clumsy
cls
echo Launching Clumsy and Clumsy_06.ahk...
start "" "%~dp0Clumsy\clumsy.exe"
start "" "%~dp0Clumsy\clumsy_06.ahk"
pause
goto page2

:antikick
cls
echo Launching AntiKick...
start "" "%~dp0Antikick\AntiKick.exe"
pause
goto page2

:minimize_program
cls
echo Minimizing the Rec Room Utilities window...
:: Minimize the current batch window without closing it
powershell -Command "(New-Object -ComObject Shell.Application).MinimizeAll()"
exit
