using ForgedCurse.Enumeration;
using ForgedCurse.Json;
using System.Threading.Tasks;

namespace HyperMC.CurseForge
{
    public interface IForgeClient
    {
        Task DownloadMod(Addon mod, string filePath);
        Task<Addon[]> SearchForMod(string modName = "", string version = "", int amount = 10, int offset = 0, MinecraftCategory category = MinecraftCategory.All, MinecraftSection seciton = MinecraftSection.Mod, AddonSorting sorting = AddonSorting.Featured);
    }
}