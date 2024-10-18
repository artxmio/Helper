using Autofac;
using Helper.View.Factories;
using Helper.View.MainView;
using Helper.ViewModel.MainViewModel;
using Helper.ViewModel.Window;

namespace Helper.Bootstrapper.WindowFactory
{
    internal class WindowFactory : IWindowFactory
    {
        private readonly IComponentContext _componentContext;

        private readonly Dictionary<Type, Type> _typeMap = new()
        {
            {typeof(IMainWindowViewModel), typeof(IMainWindow) }
        };

        public WindowFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public IWindow Create<T>(T viewModel)
            where T : IWindowViewModel
        {
            if (!_typeMap.TryGetValue(typeof(T), out var windowType))
            {
                throw new InvalidOperationException($"There is no window registered for {typeof(T)}");
            }

            var instanse = _componentContext.Resolve(windowType, TypedParameter.From(viewModel));

            return (IWindow)instanse;
        }
    }
}
