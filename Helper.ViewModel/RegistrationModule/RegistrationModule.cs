﻿using Autofac;
using Helper.ViewModel.MainViewModel;

namespace Helper.ViewModel.RegistrationModule
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().InstancePerDependency();
        }
    }
}
