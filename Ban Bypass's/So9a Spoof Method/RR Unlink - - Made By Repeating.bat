@echo off
title RR Unlinker Tool - Made By Repeating
cls

:: Show Intro
:ShowIntro
color 0A
echo.
echo =======================================================
echo        ** RR Unlinker Tool **
echo          Made By Repeating
echo =======================================================
echo.
echo Welcome to Repeatings Unlinker Tool
echo Type 'Start Unlink' to begin the unlinking process.
echo.
set /p input="Enter 'Start Unlink' to continue: "
if "%input%" neq "Start Unlink" (
    color 4F
    echo.
    echo Invalid input. Please type 'Start Unlink' to begin.
    timeout /t 3 >nul
    exit /b
)

color 0E
echo.
echo ------------------------------------------------------
echo IF THIS ERROR POPS UP:
echo "The filename, directory name, or volume label syntax is incorrect."
echo THAT MEANS IT'S ALREADY BEEN DELETED SO YOU'RE STILL UNLINKED.
echo ------------------------------------------------------
echo.
set /p continue="Type '1' to acknowledge this and continue: "
if "%continue%" neq "1" (
    echo Invalid input. Exiting...
    timeout /t 3 >nul
    exit /b
)

color 0F
echo.
echo ------------------------------------------------------
echo DISCLAIMER: IF SOME OF THE COMMANDS FAIL, THAT'S NORMAL.
echo YOUR ACCOUNT IS STILL UNLINKED.
echo ------------------------------------------------------
echo.

:: Admin Check
echo Checking for admin privileges...
color 1F
net session >nul 2>&1
if %errorlevel% neq 0 (
    color 0C
    echo You don't have admin privileges! Requesting admin access...
    echo.
    powershell -Command "Start-Process cmd -ArgumentList '/c %~f0' -Verb runAs"
    exit /b
)

color 0E
echo =======================================================
echo Starting the Unlink process...
echo =======================================================
echo.

call :typeWithDelay "Unlinking folders and files..."
call :shortDelay

:: Deleting folders and files
call :typeWithDelay "[-] Deleting folder: C:\Users\%USERNAME%\AppData\LocalLow\Against Gravity"
call :shortDelay
rmdir /s /q "C:\Users\%USERNAME%\AppData\LocalLow\Against Gravity" >nul 2>&1
color 0A
echo [+] Folder deleted: C:\Users\%USERNAME%\AppData\LocalLow\Against Gravity
call :shortDelay

call :typeWithDelay "[-] Deleting folder: %LocalAppData%\Temp\RecRoom"
call :shortDelay
rmdir /s /q "%LocalAppData%\Temp\RecRoom" >nul 2>&1
color 0A
echo [+] Folder deleted: %LocalAppData%\Temp\RecRoom
call :shortDelay

call :typeWithDelay "[-] Deleting folder: %LocalAppData%\Temp\Against Gravity"
call :shortDelay
rmdir /s /q "%LocalAppData%\Temp\Against Gravity" >nul 2>&1
color 0A
echo [+] Folder deleted: %LocalAppData%\Temp\Against Gravity
call :shortDelay

call :typeWithDelay "[-] Deleting shortcut: %AppData%\Microsoft\Windows\Recent\RecRoom.lnk"
call :shortDelay
del /s /q "%AppData%\Microsoft\Windows\Recent\RecRoom.lnk" >nul 2>&1
color 0A
echo [+] Shortcut deleted: %AppData%\Microsoft\Windows\Recent\RecRoom.lnk
call :shortDelay

call :typeWithDelay "[-] Deleting shortcut: %AppData%\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url"
call :shortDelay
del /s /q "%AppData%\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url" >nul 2>&1
color 0A
echo [+] Shortcut deleted: %AppData%\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url
call :shortDelay

:: Deleting registry keys
color 0E
echo =======================================================
echo Step 2: Deleting registry keys...
echo =======================================================
call :DeleteRegistryKey "HKEY_CURRENT_USER\Software\Against Gravity"
call :DeleteRegistryKey "HKEY_CURRENT_USER\SOFTWARE\Classes\recroom"
call :DeleteRegistryKey "HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710"
call :DeleteRegistryKey "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 471710"
call :DeleteRegistryKey "HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710"

color 0A
echo =======================================================
echo ** Unlinking Complete **
echo =======================================================
echo.
echo Done! Fully Unlinked.
echo.

:: Closing animation
echo.
call :typeWithDelay "Closing the Unlinker Tool..."
call :shortDelay
call :ClosingAnimation

:: Final Prompt
color 0E
echo ===========================================================
echo Press Enter to finish the process.
echo ===========================================================
pause >nul

:: Start Rec Room launcher prompt
set /p start_launcher="Do you want to start the Rec Room Launcher? (yes/no): "
if /i "%start_launcher%"=="yes" (
    color 0A
    echo Launching Rec Room...
    start "" "C:\Users\%USERNAME%\AppData\Local\Programs\recroom-launcher\Rec Room Launcher.exe"
) else (
    color 0C
    echo You chose not to launch Rec Room.
)

exit

:: Function to delete registry keys
:DeleteRegistryKey
set "key=%~1"
reg query "%key%" >nul 2>&1
if %errorlevel% == 0 (
    reg delete "%key%" /f >nul 2>&1
    color 0A
    echo [+] Registry key deleted: %key%
)
exit /b

:: Type with delay function
:typeWithDelay
setlocal enabledelayedexpansion
set "text=%~1"
for /l %%i in (0, 1, 999) do (
    set "char=!text:~%%i,1!"
    if "!char!"=="" goto :endTypeWithDelay
    set /p="!char!" <nul
    call :shortDelayFast
)
:endTypeWithDelay
echo.
endlocal
exit /b

:: Short delay function
:shortDelay
timeout /nobreak /t 1 >nul
exit /b

:: Fast short delay function
:shortDelayFast
ping -n 1 127.0.0.1 >nul
exit /b

:: Closing animation function
:ClosingAnimation
echo.
echo [*] Closing in 3...
timeout /t 1 >nul
echo [*] Closing in 2...
timeout /t 1 >nul
echo [*] Closing in 1...
timeout /t 1 >nul
echo.
echo Thank you for using the RR Unlinker Tool Made By Repeating!
exit /b
