@echo off
cls
SETLOCAL ENABLEDELAYEDEXPANSION
SET count=1
FOR /F "tokens=* USEBACKQ" %%F IN (`wmic logicaldisk get caption`) DO (
  SET var!count!=%%F
  SET /a count=!count!+1
  
)
echo %var1%
echo %var2%
echo %var3%
ENDLOCAL
title HWID
color 5
echo Diskdrive:
wmic diskdrive get serialnumber
echo Baseboard:
wmic baseboard get serialnumber
echo UUID(needs to change):
wmic csproduct get UUID
echo Cpu:
wmic cpu get serialnumber
echo Bios(needs to change):
wmic bios get serialnumber
echo Ram:
wmic MEMORYCHIP get serialnumber
echo Mac(s)(needs to change)
ipconfig /all | find "Physical Address" /i
pause 0