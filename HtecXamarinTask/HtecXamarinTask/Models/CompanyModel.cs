using HtecXamarinTask.DTOs;
using System.ComponentModel;

namespace HtecXamarinTask.Models
{
    public class CompanyModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Name of a Company.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Catch phrase of a Comapny.
        /// </summary>
        public string CatchPhrase { get; set; }

        /// <summary>
        /// Company Bs.
        /// </summary>
        public string Bs { get; set; }

        public CompanyModel(CompanyDto dto)
        {
            Name = dto.Name;
            CatchPhrase = dto.CatchPhrase;
            Bs = dto.Bs;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
