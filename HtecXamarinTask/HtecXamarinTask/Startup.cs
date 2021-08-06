using HtecXamarinTask.Constants;
using HtecXamarinTask.Services;
using HtecXamarinTask.Services.Interfaces;
using HtecXamarinTask.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System;
using System.Reflection;
using Xamarin.Essentials;

namespace HtecXamarinTask
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void Init()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("HtecXamarinTask.appsettings.json");

            var host = new HostBuilder()
            .ConfigureHostConfiguration(c =>
            {
                c.AddCommandLine(new string[] { $"ContentRoot={FileSystem.AppDataDirectory}" });

                c.AddJsonStream(stream);
            })
            .ConfigureServices((c, x) =>
            {
                ConfigureServices(c, x);
            })
            .Build();

            ServiceProvider = host.Services;
        }

        static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
        {
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPostRefitService, PostRefitService>();
            services.AddTransient<IUserRefitService, UserRefitService>();

            services.AddTransient<PostsPageViewModel>();
            services.AddTransient<PostOwnerDetailPageViewModel>();

            services.AddRefitClient<IPostRefitService>()
               .ConfigureHttpClient(c => c.BaseAddress = new Uri(Settings.TipycodeBaseUrl));
            services.AddRefitClient<IUserRefitService>()
               .ConfigureHttpClient(c => c.BaseAddress = new Uri(Settings.TipycodeBaseUrl));
        }
    }
}
