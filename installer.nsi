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
