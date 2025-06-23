#Persistent
#NoEnv
#SingleInstance

; Set a hotkey to focus the "Rec Room Utilities" window
F8::
    ; Check if the window with the title "Rec Room Utilities" exists
    IfWinExist, Rec Room Utilities
    {
        ; Focus the window
        WinActivate, Rec Room Utilities
    }
    return
