using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Settings
{
    public interface IUserSettings
    {
        string MinecraftPath { get; }
        string ModPacksPath { get; }
        string ModPacksFile { get; }

        Task Initialize();
    }
}
