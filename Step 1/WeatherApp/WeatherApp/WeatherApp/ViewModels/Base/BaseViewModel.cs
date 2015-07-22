namespace WeatherApp.ViewModels.Base
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;


    /// <summary>
    /// Base viewmodel for whole app.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var tmpHandler = PropertyChanged;
            if (tmpHandler != null)
                tmpHandler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
