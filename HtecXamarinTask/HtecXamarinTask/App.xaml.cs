using HtecXamarinTask.Services;
using HtecXamarinTask.Views;
using MonkeyCache.SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "Material")]
namespace HtecXamarinTask
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Barrel.ApplicationId = "HtecXamarinTask";

            Startup.Init();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
