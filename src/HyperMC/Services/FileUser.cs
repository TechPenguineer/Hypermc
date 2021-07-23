using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hypermc.Services
{
    public class FileUser : IFileUesr
    {
        public async Task<T> ReadFile<T>(string file)
        {
            if (File.Exists(file))
            {
                using var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                var settings = await JsonSerializer.DeserializeAsync<T>(stream);
                return settings;
            }

            return default(T);
        }

        public async Task WriteToFile<T>(T data, string file)
        {
            string settingsToSave = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(file, settingsToSave);
        }
    }
}
