; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PALAST"
#define MyAppVersion "2.0"
#define MyAppPublisher "Pixinger"
#define MyAppURL "https://github.com/Pixinger/YetAnotherArmaLauncher/wiki"
#define MyAppExeName "PALAST.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{3D8EA12C-82EA-460B-A548-376FF135778F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=D:\_git_src\YetAnotherArmaLauncher\source\_iss\license.txt
OutputDir=D:\_git_src\YetAnotherArmaLauncher\source
OutputBaseFilename=setupPALAST
Compression=lzma
SolidCompression=yes
ShowLanguageDialog=no
LanguageDetectionMethod=none
AppComments=Pixingers Arma Launch And Sync Tool

[Languages]
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\_git_src\YetAnotherArmaLauncher\source\_iss\PALAST.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\_git_src\YetAnotherArmaLauncher\source\_iss\NLog.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\_git_src\YetAnotherArmaLauncher\source\_iss\PALAST.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "D:\_git_src\YetAnotherArmaLauncher\source\_iss\configuration.xml"; DestDir: "{app}"; Flags: ignoreversion; Permissions: everyone-full

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
