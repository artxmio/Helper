using Autofac;
using Helper.ViewModel.MainViewModel;
using Helper.ViewModel.WindowsManager;
using System.Windows;

namespace Helper.Bootstrapper
{
    public class Bootstrapper : IDisposable
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            var container = new ContainerBuilder();

            container
                .RegisterModule<Helper.Model.RegistrationModule.RegistrationModule>()
                .RegisterModule<Helper.View.RegistrationModule.RegistrationModule>()
                .RegisterModule<Helper.ViewModel.RegistrationModule.RegistrationModule>()
                .RegisterModule<Helper.Bootstrapper.RegistrationModule.RegistrationModule>();

            _container = container.Build();
        }

        public Window Run()
        {
            var mainWindowViewModel = _container.Resolve<IMainWindowViewModel>();
            IWindowManager windowManager = _container.Resolve<IWindowManager>();

            var mainWindow = windowManager.Show(mainWindowViewModel);

            if (mainWindow is not Window window)
            {
                throw new NotImplementedException();
            }

            return window;
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
