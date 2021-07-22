
using System;
using System.IO;

namespace HyperMcSettings
{
    public class manager
    {
        string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.hypermc\\settings";

        public void createSettingsFolder(string SettingFileName)
        {
            string setting_file_path = $"{path}\\{SettingFileName}";
            if(!Directory.Exists(setting_file_path))
            {
                Directory.CreateDirectory(setting_file_path);
            }
        }
        public void addSetting(string settingName, string settingValue)
        {

        }
    }
}