using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Services
{
    public interface IDataAccess
    {
        Task SaveData<T>(T data, string file);
        Task<T> LoadData<T>(string file);
        Task<List<T>> LoadData<T, U>(string query, U parameters, string connectionStringName);
        Task SaveData<T>(string query, T parameters, string connectionStringName);
    }
}
