using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Services
{
    public interface IFileManager
    {
        Task WriteToFile<T>(T data, string file);
        Task<T> ReadFile<T>(string file);
    }
}
