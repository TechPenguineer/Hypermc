using Hypermc.Services;
using Hypermc.Settings;
using Hypermc.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc
{
    static class Program
    {
        private static IServiceProvider Provider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Provider = ConfigureService();
            await Provider.GetRequiredService<IUserSettings>().Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Provider.GetRequiredService<HyperMcView>());
        }

        private static IServiceProvider ConfigureService()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<HyperMcView>()
                    .AddSingleton<IUserSettings, UserSettings>();

            services.AddTransient<SettingView>()
                    .AddTransient<IFileManager, FileManager>();

            services.AddForgeClient();

            return services.BuildServiceProvider();
        }
    }
}
