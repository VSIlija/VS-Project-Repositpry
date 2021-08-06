using HtecXamarinTask.ViewModels;
using Xamarin.Forms.Xaml;

namespace HtecXamarinTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostsPage : BasePage
    {
        public PostsPage()
        {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService(typeof(PostsPageViewModel));
        }
    }
}