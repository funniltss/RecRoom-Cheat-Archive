#NoEnv
#SingleInstance Force
SetWorkingDir %A_ScriptDir%
SendMode Input

if not A_IsAdmin
    Run *RunAs "%A_ScriptFullPath%"

global selectedApp := ""
global isEnabled := 0

; Enhanced UI with transparent background and grid
Gui +AlwaysOnTop -SysMenu +LastFound +Border
WinSet, Transparent, 200
Gui Color, 000000
Gui Font, s10 cFF6600, Segoe UI

; Add grid lines
Loop, 8 {
    yPos := A_Index * 40
    Gui Add, Text, x0 y%yPos% w405 h1 cFF6600, % "────────────────────────────"
}
Loop, 4 {
    xPos := A_Index * 100
    Gui Add, Text, x%xPos% y0 w1 h310 cFF6600, % "│"
}

; Custom title bar with minimize
Gui Add, Text, x10 y5 w200 cFF6600, 
Gui Add, Button, x350 y5 w20 h20 gGuiMinimize, _
Gui Add, Button, x375 y5 w20 h20 gGuiClose, X

; Main interface
Gui Add, GroupBox, x10 y35 w385 h265 cFF6600,

; Target selection
Gui Add, Text, x25 y60 w200 cFF6600, SELECT APPLICATION:
Gui Add, ComboBox, x25 y80 w330 vSelectedApp gAppChange, Loading...
Gui Add, Button, x360 y79 w25 h25 gRefreshApps, R

; Hotkey selection
Gui Add, Text, x25 y120 w200 cFF6600, SELECT HOTKEY:
Gui Add, DropDownList, x25 y140 w360 vButtonChosse gChangeButton, F1|SPACE|F2|F3|F4|F5|F6|F7|F8|F9|F10|F11|F12|MButton|LButton|RButton|XButton1|XButton2|ScrollLock|Delete|Insert|Home|End|PgUp|PgDn|Up|Down|Left|Numpad0|Numpad1|Numpad2|Numpad3|Numpad4|Numpad5|Numpad6|Numpad7|Numpad8|Numpad9|NumpadDot|NumLock|NumpadDiv|NumpadMult|NumpadAdd|NumpadSub|NumpadEnter|RAlt|LAlt|LShift|RShift|-|=|[|]|{|}|\|;|'|,|.|/|q|w|e|r|t|y|u|i|o|p|a|s|d|f|g|h|j|k|l|z|x|c|v|b|n|m|0|1|2|3|4|5|6|7|8|9|none

; Status display
Gui Add, Text, x25 y190 w360 vStatusText cFF6600 Center, READY

; Action buttons
Gui Add, Button, x25 y220 w360 h35 vToggleBtn gToggleState, ENABLE
Gui Add, Button, x25 y260 w360 h30 gGuiClose, EXIT


Gui Show, w405 h310, VOID AHK v1.1

; Enhanced tray menu
Menu, Tray, NoStandard
Menu, Tray, Add, Show VOID, ShowGui
Menu, Tray, Add
Menu, Tray, Add, Exit, ExitApp
Menu, Tray, Default, Show VOID
Menu, Tray, Tip, VOID AHK v1.1

GoSub, RefreshApps
return

RefreshApps:
WinGet, id, List,,, Program Manager
appList := ""
Loop, %id%
{
    this_id := id%A_Index%
    WinGet, exe, ProcessName, ahk_id %this_id%
    WinGetTitle, title, ahk_id %this_id%
    if (title && title != "Select application")
        appList .= title "|"
}
GuiControl,, SelectedApp, |%appList%
GuiControl,, StatusText, APPLICATIONS REFRESHED
return

AppChange:
GuiControlGet, selectedApp,, SelectedApp
GuiControl,, StatusText, TARGET: %selectedApp%
return

ChangeButton:
GuiControlGet, checkifnull,, ButtonChosse
if (oldbutton)
    Hotkey, %oldbutton%, Off
Hotkey, ~%checkifnull%, StartLag
oldbutton := checkifnull
GuiControl,, StatusText, HOTKEY SET: %checkifnull%
return

ShowGui:
Gui Show
return

GuiMinimize:
Gui Minimize
return

StartLag:
if (isEnabled)
    ControlClick, Button2, %selectedApp%
return

ToggleState:
isEnabled := !isEnabled
GuiControl,, ToggleBtn, % (isEnabled ? "DISABLE " : "ENABLE ")
GuiControl,, StatusText, % (isEnabled ? " ACTIVE" : " INACTIVE")
return

GuiClose:
ExitApp
