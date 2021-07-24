using Hypermc.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc.Settings
{
    public class UserSettings : IUserSettings
    {
        private readonly string _appPath;
        private readonly string _settingsFile;
        private readonly IFileManager _fileManager;

        public string MinecraftPath { get; private set; }
        public string ModPacksPath { get; private set; }
        public string ModPacksFilePath { get; }

        public UserSettings(IFileManager fileManager, IConfiguration config)
        {
            var settings = config.Get<ApplicationSettings>().AppSettings;            
            _appPath = string.Format(settings.AppPath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            _settingsFile = string.Format(settings.SettingsFile, _appPath);

            _fileManager = fileManager;

            MinecraftPath = string.Format(settings.DeafultMinecraftPath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            ModPacksPath = string.Format(settings.DefaultModPacksPath, MinecraftPath);
            ModPacksFilePath = string.Format(settings.DefaultModPacksFilePath, ModPacksPath);
        }

        public async Task Initialize()
        {
            if (!Directory.Exists(_appPath))
            {
                Directory.CreateDirectory(_appPath);
            }

            if (!Directory.Exists(ModPacksFilePath))
            {
                Directory.CreateDirectory(ModPacksFilePath);
            }

            var settings = await _fileManager.ReadFile<UserSettings>(_settingsFile);

            if (settings != null)
            {
                MinecraftPath = settings.MinecraftPath;
                ModPacksPath = settings.ModPacksFilePath;
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
