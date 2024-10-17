using Autofac;
using Helper.Model.MainModel;

namespace Helper.Model.RegistrationModule
{
    public class RegistrationModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);


            builder.RegisterType<MainWindowModel>().As<IMainWindowModel>().InstancePerDependency();
        }
    }
}
