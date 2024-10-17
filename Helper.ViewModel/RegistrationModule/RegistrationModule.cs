using Autofac;
using Helper.Model.MainModel;

namespace Helper.ViewModel.RegistrationModule
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<IMainWindowModel>().As<IMainWindowModel>().InstancePerDependency();
        }
    }
}
