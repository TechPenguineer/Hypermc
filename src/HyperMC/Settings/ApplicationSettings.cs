using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Settings
{
    public class ApplicationSettings
    {
        public AppSettings AppSettings { get; set; }
    }

    public class AppSettings
    {
        public string AppPath { get; set; }
        public string DeafultMinecraftPath { get; set; }
        public string DefaultModPacksFilePath { get; set; }
        public string DefaultModPacksPath { get; set; }
        public string SettingsFile { get; set; }
    }
}
