using Forge = ForgedCurse;
using ForgedCurse.Enumeration;
using ForgedCurse.Json;
using ForgedCurse.Utility;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HyperMC.CurseForge
{
    public class ForgeClient : IForgeClient
    {
        private readonly Forge.ForgeClient _forgeClient;

        public ForgeClient()
        {
            _forgeClient = new();
        }
        public async Task DownloadMod(Addon mod, string filePath)
        {
            string downloadUrl = await _forgeClient.Files.RetrieveDownloadUrl(mod.Identifier, mod.Files[0].FileId);
            using var response = await _forgeClient.HttpClient.GetAsync(downloadUrl);

            if (response.IsSuccessStatusCode)
            {
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    // TODO: Change this out to be the correct output directory
                    //       fileName can also be whatever name is desired
                    int index = downloadUrl.LastIndexOf('/');
                    string fileName = downloadUrl.Substring(index + 1);

                    using (StreamWriter writer = new StreamWriter($"{filePath}\\{fileName}"))
                    {
                        await stream.CopyToAsync(writer.BaseStream);
                    }
                }
            }
        }
        public async Task<Addon[]> SearchForMod(string modName = "", string version = "", int amount = 10, int offset = 0, MinecraftCategory category = MinecraftCategory.All,
                                         MinecraftSection seciton = MinecraftSection.Mod, AddonSorting sorting = AddonSorting.Featured)
        {
            AddonQueryBuilder builder = new()
            {
                Amount = amount,
                Offset = offset,
                Game = (int)ForgeGames.Minecraft,
                Category = (int)category,
                Section = (int)seciton,
                Sorting = sorting,
                Name = modName,
                Version = version
            };

            return await _forgeClient.Addons.SearchAddons(builder);
        }

        public async Task<Addon> GetModById(int modId)
        {
            return await _forgeClient.Addons.RetriveAddon(modId);
        }

        public async Task<MinecraftVersion[]> GetMinecraftVersions()
        {
            return await _forgeClient.Minecraft.RetrieveGameVersions();
        }

        public async Task<Stream> GetImageFromURL(string url)
        {
            var result = await _forgeClient.HttpClient.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadAsStreamAsync();
            }

            return null;
        }
    }
}
