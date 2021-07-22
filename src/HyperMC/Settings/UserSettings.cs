using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Settings
{
    public class UserSettings : IUserSettings
    {
        public string MinecraftPath { get; set; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft";

        // TODO: intialize settings by getting the users saved settings for this application
        public void Initialize()
        {
            
        }
    }
}
