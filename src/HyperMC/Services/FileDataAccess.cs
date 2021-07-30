using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hypermc.Services
{
    public class FileDataAccess : IDataAccess
    {
        public async Task<T> LoadData<T>(string file)
        {
            if (File.Exists(file))
            {
                using var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                var settings = await JsonSerializer.DeserializeAsync<T>(stream);
                return settings;
            }

            return default(T);
        }

        public async Task SaveData<T>(T data, string file)
        {
            string settingsToSave = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(file, settingsToSave);
        }

        public Task<List<T>> LoadData<T, U>(string query, U parameters, string connectionStringName)
        {
            return null;
        }
        public Task SaveData<T>(string query, T parameters, string connectionStringName)
        {
            return null;
        }
    }
}
