using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherApp.ViewModels.Base
{

    /// <summary>
    /// Base viewmodel for whole app.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raise PropertyChanged event to nofity view of data changes
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged ([CallerMemberName]string propertyName = "")
        {
            var tmpHandler = PropertyChanged;
            if (tmpHandler != null)
                tmpHandler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
