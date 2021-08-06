using HtecXamarinTask.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HtecXamarinTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage
    {
        public BasePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var bindingContext = BindingContext as BaseViewModel;

            if (bindingContext != null)
                bindingContext.OnAppearing();
        }
    }
}