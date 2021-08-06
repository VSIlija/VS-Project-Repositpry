using HtecXamarinTask.ViewModels;
using Xamarin.Forms.Xaml;

namespace HtecXamarinTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostOwnerDetailPage : BasePage
    {
        public PostOwnerDetailPage()
        {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService(typeof(PostOwnerDetailPageViewModel));
        }
    }
}