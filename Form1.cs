using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hypermc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc");
        }

        private void docsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/tree/main/docs");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/issues/new");
        }

        private void downloadNewReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/releases");
        }

        private String GetJavaInstallationPath()
        {
            String javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey))
            {
                String currentVersion = baseKey.GetValue("CurrentVersion").ToString();
                using (var homeKey = baseKey.OpenSubKey(currentVersion))
                    return homeKey.GetValue("JavaHome").ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e, string username, string accessToken, string uuid, string gameVersion)
        {
            ProcessStartInfo minecraft = new ProcessStartInfo
            {
                FileName = GetJavaInstallationPath() + @"/bin/javaw.exe",
                CreateNoWindow = false,
                Arguments = " -XX:+UseConcMarkSweepGC -XX:-UseAdaptiveSizePolicy -XX:+CMSParallelRemarkEnabled -XX:+ParallelRefProcEnabled -XX:+CMSClassUnloadingEnabled -XX:+UseCMSInitiatingOccupancyOnly -Xmx1024M -Dfile.encoding=UTF-8 -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Xss1M -Djava.library.path=C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/versions/" + gameVersion + "/natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=1.6.84-j -cp C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/oshi-project/oshi-core/1.1/oshi-core-1.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/net/java/dev/jna/jna/4.4.0/jna-4.4.0.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/net/java/dev/jna/platform/3.4.0/platform-3.4.0.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/ibm/icu/icu4j/66.1/icu4j-66.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/mojang/javabridge/1.0.22/javabridge-1.0.22.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/net/sf/jopt-simple/jopt-simple/5.0.3/jopt-simple-5.0.3.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/io/netty/netty-all/4.1.25.Final/netty-all-4.1.25.Final.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/google/guava/guava/21.0/guava-21.0.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-lang3/3.5/commons-lang3-3.5.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/commons-io/commons-io/2.5/commons-io-2.5.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/commons-codec/commons-codec/1.10/commons-codec-1.10.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/net/java/jinput/jinput/2.0.5/jinput-2.0.5.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/net/java/jutils/jutils/1.0.0/jutils-1.0.0.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/mojang/brigadier/1.0.17/brigadier-1.0.17.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/mojang/datafixerupper/4.0.26/datafixerupper-4.0.26.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/google/code/gson/gson/2.8.0/gson-2.8.0.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-compress/1.8.1/commons-compress-1.8.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpclient/4.3.3/httpclient-4.3.3.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/commons-logging/commons-logging/1.1.3/commons-logging-1.1.3.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpcore/4.3.2/httpcore-4.3.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/it/unimi/dsi/fastutil/8.2.1/fastutil-8.2.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-api/2.8.1/log4j-api-2.8.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-core/2.8.1/log4j-core-2.8.1.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl/3.2.2/lwjgl-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-jemalloc/3.2.2/lwjgl-jemalloc-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-openal/3.2.2/lwjgl-openal-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-opengl/3.2.2/lwjgl-opengl-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-glfw/3.2.2/lwjgl-glfw-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-stb/3.2.2/lwjgl-stb-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-tinyfd/3.2.2/lwjgl-tinyfd-3.2.2.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/com/mojang/text2speech/1.11.3/text2speech-1.11.3.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/libraries/by/ely/authlib/2.0.27.4/authlib-2.0.27.4.jar;C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/versions/" + gameVersion + "/" + gameVersion + ".jar net.minecraft.client.main.Main --username " + username + " --version " + gameVersion + " --gameDir C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft --assetsDir C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft/assets --assetIndex " + gameVersion + " --uuid " + uuid + " --accessToken " + accessToken + " --userType legacy --versionType release --width 925 --height 530"
            };
        }

        private void launch_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
