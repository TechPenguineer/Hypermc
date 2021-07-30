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
        private readonly IDataAccess _dataAccess;

        public string MinecraftPath { get; private set; }
        public string ModPacksPath { get; private set; }
        public string ModPacksFile { get; }

        public UserSettings(IDataAccess dataAccess, IConfiguration config)
        {
            var settings = config.GetSection(nameof(ApplicationSettings)).Get<ApplicationSettings>();
            _appPath = string.Format(settings.AppPath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            _settingsFile = string.Format(settings.SettingsFile, _appPath);

            _dataAccess = dataAccess;

            MinecraftPath = string.Format(settings.DeafultMinecraftPath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            ModPacksPath = string.Format(settings.DefaultModPacksPath, MinecraftPath);
            ModPacksFile = string.Format(settings.ModPacksFile, ModPacksPath);
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

            var settings = await _dataAccess.LoadData<UserSettings, int, UserSettings>(_settingsFile);

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

            await _dataAccess.SaveData(_settingsFile, this);
        }
    }
}
