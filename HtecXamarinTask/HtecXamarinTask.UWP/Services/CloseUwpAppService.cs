using HtecXamarinTask.Services.Interfaces;
using HtecXamarinTask.UWP.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseUwpAppService))]
namespace HtecXamarinTask.UWP.Services
{
    public class CloseUwpAppService : ICloseAppService
    {
        public void CloseApplication()
        {
            Windows.UI.Xaml.Application.Current.Exit();
        }
    }
}
