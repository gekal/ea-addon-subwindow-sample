# ea_sample_subwindow

set TlbFileName=$(ProjectName).tlb

rem ■■ DLLコピー ■■
copy $(TargetFileName) "..\..\..\setup\$(TargetFileName)"
copy $(TargetFileName) "C:\Program Files (x86)\SparxSystems Japan\EA\$(TargetFileName)"
copy %TlbFileName% "..\..\..\setup\%TlbFileName%"
copy %TlbFileName% "C:\Program Files (x86)\SparxSystems Japan\EA\%TlbFileName%"

rem ■■ DLL登録 ■■
cd "C:\Program Files (x86)\SparxSystems Japan\EA"
set DotNetReg="%SystemRoot%\Microsoft.NET\Framework\v4.0.30319"
%DotNetReg%\RegAsm.exe "$(TargetFileName)" /tlb /codebase

rem ■■ レジストリ登録 ■■
set RegistoryPath="HKCU\Software\Sparx Systems\EAAddins\EASampleWithWindow"
IF EXIST "%SystemRoot%\syswow64\reg.exe" (
 set RegExeFolder="%SystemRoot%\syswow64"
) ELSE (
 set RegExeFolder="%SystemRoot%\system32"
)
%RegExeFolder%\reg.exe add %RegistoryPath% /ve /f /d AddinMainWithWindow.AddinMain
