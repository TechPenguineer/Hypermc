using Hypermc.Services;
using Hypermc.Settings;
using Hypermc.UI.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
            builder.Build();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            await host.Services.GetRequiredService<IUserSettings>().Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(host.Services.GetRequiredService<HyperMcView>());
        }

        private static IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<HyperMcView>()
                    .AddSingleton<IUserSettings, UserSettings>();

            services.AddTransient<SettingView>()
                    .AddTransient<IFileManager, FileManager>();

            services.AddForgeClient();

            return services.BuildServiceProvider();
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{ Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production" }.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
