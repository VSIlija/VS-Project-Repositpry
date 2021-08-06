using HtecXamarinTask.Services.Interfaces;
using HtecXamarinTask.ViewModels;
using HtecXamarinTask.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HtecXamarinTask
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PostsPage), typeof(PostsPage));
            Routing.RegisterRoute(nameof(PostOwnerDetailPage), typeof(PostOwnerDetailPage));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ICloseAppService>().CloseApplication();
        }
    }
}
