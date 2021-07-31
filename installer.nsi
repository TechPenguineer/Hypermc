!define APP_NAME "HyperMc"
!define APP_VERSION "1.0.0"

!define INSTALLER_TITLE "${APP_NAME} - ${APP_VERSION} - Setup"
!define UNINSTALLER_TITLE "${APP_NAME} - ${APP_VERSION} - Uninstaller"

!addincludedir "./"

!include "MUI.nsh"
!include "MUI2.nsh"

SetCompressor lzma

!insertmacro MUI_LANGUAGE "English"

RequestExecutionLevel user

; ---------------------- PAGES ----------------------
Page directory 
Page instfiles

; ---------------------- INSTALL ---------------------- 

Name "${INSTALLER_TITLE}"
OutFile "hypermc-setup-${APP_VERSION}.exe"
InstallDir "$PROGRAMFILES\Hypermc" 
ShowUnInstDetails show

Section "MainSection" SEC01
   
SectionEnd


; ---------------------- FUNCITONS ----------------------
Function .onVerifyInstDir
  ReadEnvStr $0 "ProgramFiles(x86)"
  StrCmp $0 $INSTDIR 0 PathGood
  MessageBox MB_OK "directory not valid for installation"
  Abort
PathGood:
FunctionEnd