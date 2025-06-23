#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
DetectHiddenWindows On
SetTitleMatchMode 1 
SetBatchLines, -1
#NoEnv
#SingleInstance Force
if not A_IsAdmin
    Run *RunAs "%A_ScriptFullPath%"



q:: 

    ControlClick, Button2, 0.6

return





F4::
    ExitApp
return