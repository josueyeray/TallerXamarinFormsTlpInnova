﻿namespace WeatherApp.Views
{ 
    using ViewModels;
    using Xamarin.Forms;

    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = App.Locator.Resolve<MainViewModel>();
        }
    }
}
