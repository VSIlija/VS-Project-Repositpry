using Android.OS;
using HtecXamarinTask.Droid.Services;
using HtecXamarinTask.Services.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseAndroidAppService))]
namespace HtecXamarinTask.Droid.Services
{
    public class CloseAndroidAppService : ICloseAppService
    {
        public void CloseApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}