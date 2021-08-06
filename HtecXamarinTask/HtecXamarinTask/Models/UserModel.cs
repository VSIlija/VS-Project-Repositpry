using HtecXamarinTask.DTOs;
using System.ComponentModel;

namespace HtecXamarinTask.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Id of a User.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Username of a user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User full adress imnformation.
        /// </summary>
        public AddressModel Address { get; set; }

        /// <summary>
        /// User phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// User website address.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// User full comapny information.
        /// </summary>
        public CompanyModel Company { get; set; }

        public UserModel(UserDto dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Username = dto.Username;
            Email = dto.Email;
            Address = new AddressModel(dto.Address);
            Phone = dto.Phone;
            Website = dto.Website;
            Company = new CompanyModel(dto.Company);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
