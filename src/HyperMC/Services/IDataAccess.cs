using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Services
{
    public interface IDataAccess
    {
        /// <summary>
        /// Loads data from a file or database
        /// </summary>
        /// <typeparam name="T">The input type for the data that you want to be loaded</typeparam>
        /// <typeparam name="U">The type of the data that is being passed in to be saved</typeparam>
        /// <typeparam name="O">The return type</typeparam>
        /// <param name="fileOrQuery">The file name or query string to run</param>
        /// <param name="parameters">The data to query the database on</param>
        /// <param name="connectionStringName">The connection string name for the database</param>
        /// <returns></returns>
        Task<O> LoadData<T, U, O>(string fileOrQuery, U parameters = default(U), string connectionStringName = null);

        /// <summary>
        /// Saves data to a file or database
        /// </summary>
        /// <typeparam name="T">The data type that is being passed in</typeparam>
        /// <param name="fileOrQuery">The file name or query string to run</param>
        /// <param name="parametersOrData">The data to be saved to the file or database</param>
        /// <param name="connectionStringName">The connection string name for the database</param>
        /// <returns></returns>
        Task SaveData<T>(string fileOrQuery, T parametersOrData = default(T), string connectionStringName = null);
    }
}
