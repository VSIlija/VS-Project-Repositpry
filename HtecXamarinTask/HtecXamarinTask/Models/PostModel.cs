using HtecXamarinTask.DTOs;
using System.ComponentModel;

namespace HtecXamarinTask.Models
{
    public class PostModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Id of post owner.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Id of a Post.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post Title text.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Post body text.
        /// </summary>
        public string Body { get; set; }

        public PostModel(PostDto dto)
        {
            UserId = dto.UserId;
            Id = dto.Id;
            Title = dto.Title;
            Body = dto.Body;
        }

        public PostModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
