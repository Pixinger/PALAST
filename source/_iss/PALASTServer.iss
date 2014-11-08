; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PALAST Server"
#define MyAppPublisher "Pixinger"
#define MyAppURL "https://github.com/Pixinger/PALAST/wiki"
#define MyAppExeName "PALASTServer.exe"
#define MyAppVersion GetFileVersion(AddBackslash(SourcePath) + "PALASTServer.exe")


[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E3512B7C-26B9-4CFB-AF60-3DA7E9E8DB93}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=D:\_git_src\PALAST\source\_iss\license.txt
OutputDir=D:\_git_src\PALAST\_releases
OutputBaseFilename=setupPALASTServer
SetupIconFile=D:\_git_src\PALAST\source\PALASTServer\Rocket.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\_git_src\PALAST\source\_iss\PALASTServer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\_git_src\PALAST\source\_iss\license.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\_git_src\PALAST\source\_iss\NLog.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
