using Acr.UserDialogs;
using Refit;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HtecXamarinTask.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }

        /// <summary>
        /// Handle exeptions for each API call wrapped in this method
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        protected async Task InvokeServiceAsync(Func<Task> service)
        {
            try
            {
                IsBusy = true;

                await service();
            }
            catch (ApiException apiExeption)
            {
                await UserDialogs.Instance.AlertAsync(apiExeption.Message);
            }
            catch (Exception e)
            {
                await UserDialogs.Instance.AlertAsync(e.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public virtual void OnAppearing() { }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
