using Autofac;
using Helper.View.MainView;
using Helper.ViewModel.WindowsManager;

namespace Helper.View.RegistrationModule
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainWindow>().As<IMainWindow>().InstancePerDependency();
            builder.RegisterType<WindowsManager.WindowsManager>().As<IWindowManager>().SingleInstance();
        }
    }
}
