using HtecXamarinTask.Constants;
using HtecXamarinTask.DTOs;
using HtecXamarinTask.Models;
using HtecXamarinTask.Services.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HtecXamarinTask.ViewModels
{
    [QueryProperty(nameof(selectedPostJson), nameof(selectedPostJson))]
    public class PostOwnerDetailPageViewModel : BaseViewModel
    {
        private readonly IUserRefitService _userRefitService;
        private readonly IPostService _postService;
        public Command DeletePostCommand { get; set; }
        public PostModel Post { get; set; }
        public UserModel User { get; set; }
        public string selectedPostJson { get; set; }

        public PostOwnerDetailPageViewModel(IUserRefitService userRefitService, IPostService postService)
        {
            _userRefitService = userRefitService;
            _postService = postService;
            DeletePostCommand = new Command(DeletePost);
            Post = new PostModel();
        }

        public async override void OnAppearing()
        {
            Post = JsonConvert.DeserializeObject<PostModel>(selectedPostJson);
            await FetchUser();
        }

        private async Task FetchUser() 
        {
            var userDtos = new List<UserDto>();
            await InvokeServiceAsync(async () => {
                userDtos = await _userRefitService.GetById(Post.UserId);

                var dto = userDtos.FirstOrDefault();
                if (dto != null)
                {
                    User = new UserModel(dto);
                } 
            });
        }

        private async void DeletePost()
        {
            await InvokeServiceAsync(async () => {
                await _postService.DeleteAsync(Post);
                await Shell.Current.GoToAsync(Settings.NavigateBack);
            });
        }
    }
}