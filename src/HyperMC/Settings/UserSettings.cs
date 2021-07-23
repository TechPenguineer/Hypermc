using Hypermc.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hypermc.Settings
{
    public class UserSettings : IUserSettings
    {
        private readonly string _appPath;
        private readonly string _settingsFile;
        private readonly IFileUesr _fileUesr;

        public string MinecraftPath { get; set; }
        public string ModPacksPath { get; set; }

        public UserSettings(IFileUesr fileUesr)
        {
            // TODO: possibly move the file names to the appsettings.
            _appPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.hypermc";
            _settingsFile = $@"{_appPath}\settings.json";
            _fileUesr = fileUesr;

            MinecraftPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft";
            ModPacksPath = $@"{MinecraftPath}\ModPacks";
        }

        public async Task Initialize()
        {
            if (!Directory.Exists(_appPath))
            {
                Directory.CreateDirectory(_appPath);
            }

            var settings = await _fileUesr.ReadFile<UserSettings>(_settingsFile);

            if (settings != null)
            {
                MinecraftPath = settings.MinecraftPath;
                ModPacksPath = settings.ModPacksPath;
            }
        }

        public async Task UpdateSettings(string mcPath, string modPath)
        {
            MinecraftPath = mcPath;
            ModPacksPath = modPath;

            await _fileUesr.WriteToFile(this, _settingsFile);
        }
    }
}
