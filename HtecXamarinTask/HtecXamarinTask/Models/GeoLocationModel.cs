using HtecXamarinTask.DTOs;
using System.ComponentModel;

namespace HtecXamarinTask.Models
{
    public class GeoLocationModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Address latitude.
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Adress longitude.
        /// </summary>
        public string Longitude { get; set; }

        public GeoLocationModel(GeoLocationDto dto)
        {
            Latitude = dto.Lat;
            Longitude = dto.Lng;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
