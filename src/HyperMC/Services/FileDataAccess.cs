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
        public async Task<O> LoadData<T, U, O>(string fileOrQuery, U parameters = default(U), string connectionStringName = null)
        {
            if (File.Exists(fileOrQuery))
            {
                using var stream = new FileStream(fileOrQuery, FileMode.Open, FileAccess.Read);
                var settings = await JsonSerializer.DeserializeAsync<O>(stream);
                return settings;
            }

            return default(O);
        }

        public async Task SaveData<T>(string fileOrQuery, T parametersOrData, string connectionStringName = null)
        {
            string settingsToSave = JsonSerializer.Serialize(parametersOrData);
            await File.WriteAllTextAsync(fileOrQuery, settingsToSave);
        }
    }
}
