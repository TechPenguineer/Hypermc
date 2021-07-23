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
        private readonly IFileManager _fileManager;

        public string MinecraftPath { get; set; }
        public string ModPacksPath { get; set; }

        public UserSettings(IFileManager fileManager)
        {
            // TODO: possibly move the file names to the appsettings.
            _appPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.hypermc";
            _settingsFile = $@"{_appPath}\settings.json";
            _fileManager = fileManager;

            MinecraftPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft";
            ModPacksPath = $@"{MinecraftPath}\ModPacks";
        }

        public async Task Initialize()
        {
            if (!Directory.Exists(_appPath))
            {
                Directory.CreateDirectory(_appPath);
            }

            if (!Directory.Exists(ModPacksPath))
            {
                Directory.CreateDirectory(ModPacksPath);
            }

            var settings = await _fileManager.ReadFile<UserSettings>(_settingsFile);

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

            await _fileManager.WriteToFile(this, _settingsFile);
        }
    }
}
