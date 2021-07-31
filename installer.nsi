!define APP_NAME "HyperMc"
!define APP_VERSION "1.0.0"

!define INSTALLER_TITLE = "${APP_NAME} - ${APP_VERSION} - Setup"

!addincludedir "./"

!include "MUI.nsh"

SetCompressor lzma

!insertmacro MUI_LANGUAGE "English"

Name ${INSTALLER_TITLE}
OutFile "hypermc-setup-${APP_VERSION}.exe"