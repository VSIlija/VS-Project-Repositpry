using HtecXamarinTask.DTOs;
using System.ComponentModel;

namespace HtecXamarinTask.Models
{
    public class AddressModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Street of address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Adress suite.
        /// </summary>
        public string Suite { get; set; }

        /// <summary>
        /// Address city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Address zip code.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Address geo location(latitude, longitude).
        /// </summary>
        public GeoLocationModel GeoLocation { get; set; }

        public AddressModel(AddressDto dto)
        {
            Street = dto.Street;
            Suite = dto.Suite;
            City = dto.City;
            ZipCode = dto.ZipCode;
            GeoLocation = new GeoLocationModel(dto.Geo);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
