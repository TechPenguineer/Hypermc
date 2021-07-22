using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgedCurse;






namespace HypermcData
{
    public class VersionData
    {
        
        ForgeClient client = new ForgeClient();

        public void getForgeVersions()
        {
        }
        public void getMinecraftVersions()
        {
            
            client.Minecraft.RetrieveGameVersions();
        }
    };
}