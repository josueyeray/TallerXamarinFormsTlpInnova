namespace WeatherApp.ViewModels.Base
{
    using Autofac;
    using WeatherApp.Services.WeatherService;

    public class ViewModelLocator
    {
        private IContainer container;
        private ContainerBuilder builder;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ViewModelLocator()
        {
            this.builder = new ContainerBuilder();
            RegisterCommonTypes();
        }

        /// <summary>
        /// THis method allow you to register a contract + implementation service in the container
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        public void RegisterService<TFrom, TTo>()
        {
            this.builder.RegisterType<TTo>().As<TFrom>();
        }

        /// <summary>
        /// This method allow you to build the container for use.
        /// </summary>
        public void BuildContainer()
        {
            this.container = this.builder.Build();
        }

        /// <summary>
        /// This method allow you to resolve a type instance directly from the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

        internal void RegisterCommonTypes()
        {
            this.builder.RegisterType<WeatherService>().As<IWeatherService>();
            this.builder.RegisterType<MainViewModel>();
        }
    }
}
