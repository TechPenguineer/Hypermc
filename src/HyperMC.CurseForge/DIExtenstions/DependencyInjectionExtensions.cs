using HyperMC.CurseForge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddForgeClient(this IServiceCollection services)
        {
            return services.AddSingleton<IForgeClient, ForgeClient>();
        }
    }
}
