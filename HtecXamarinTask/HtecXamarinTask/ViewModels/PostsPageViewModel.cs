using HtecXamarinTask.Models;
using HtecXamarinTask.Services.Interfaces;
using HtecXamarinTask.Views;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HtecXamarinTask.ViewModels
{
    public class PostsPageViewModel : BaseViewModel
    {
        private readonly IPostService _postsService;

        public Command ReloadPostsCommand { get; set; }
        public Command OnPostSelectedCommand { get; set; }

        public ObservableCollection<PostModel> Posts { get; set; }
        public PostModel SelectedPost { get; set; }

        public PostsPageViewModel(IPostService postsService)
        {
            _postsService = postsService;
            ReloadPostsCommand = new Command(async () => await ReloadPosts());
            OnPostSelectedCommand = new Command(OnPostSelected);
        }

        public async override void OnAppearing()
        {
            await FetchPosts();
        }

        private async Task FetchPosts()
        {
            await InvokeServiceAsync(async () => { 
                var posts = await _postsService.GetAllAsync();
                Posts = new ObservableCollection<PostModel>(posts);
            });
        }

        private async Task ReloadPosts()
        {
            await InvokeServiceAsync(async () => {
                var posts = await _postsService.ReloadAsync();
                Posts = new ObservableCollection<PostModel>(posts);
            });
        }

        private async void OnPostSelected()
        {
            string selectedPostJson = JsonConvert.SerializeObject(SelectedPost);
            await Shell.Current.GoToAsync($"{nameof(PostOwnerDetailPage)}?{nameof(selectedPostJson)}={selectedPostJson.Replace("\\n", "\n")}");
        }
    }
}
