using Autofac;
using Helper.View.Factories;

namespace Helper.Bootstrapper.RegistrationModule
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<WindowFactory.WindowFactory>().As<IWindowFactory>().SingleInstance();
        }
    }
}
