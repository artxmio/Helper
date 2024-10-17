using Autofac;

namespace Helper.Bootstrapper
{
    public class Bootstrapper : IDisposable
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            var container = new ContainerBuilder();


            container.RegisterModule<Helper.Model.RegistrationModule.RegistrationModule>();
            container.RegisterModule<Helper.View.RegistrationModule.RegistrationModule>();
            container.RegisterModule<Helper.ViewModel.RegistrationModule.RegistrationModule>();

            _container = container.Build();
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
