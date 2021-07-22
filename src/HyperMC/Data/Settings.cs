
using System;
using System.IO;

namespace HyperMcSettings
{
    public class manager
    {

        string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.hypermc\\settings";

        public void createSettingsFolder(string SettingType)
        {
            string setting_file_path = $"{path}\\{SettingType}";
            if(!Directory.Exists(setting_file_path))
            {
                Directory.CreateDirectory(setting_file_path);
            }
        }
        public void addSetting(string settingFolder, string settingName, string settingValue, bool overwriteIfExists)
        {
            void checkIfExists()
            {
                if (!Directory.Exists($"{path}\\{settingFolder}"))
                {
                    createSettingsFolder(settingFolder);
                }
            }
            void writeSettingFile()
            {
                if(File.Exists($"{path}\\{settingFolder}\\{settingName}") && overwriteIfExists)
                {
                    File.Create($"{path}\\{settingFolder}\\{settingName}.json");
                }
            }

            void writeSetting()
            {
            
            }

            
            checkIfExists();
            writeSettingFile();



            
        }
    }
}