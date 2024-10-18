using Helper.View.Factories;
using Helper.ViewModel.Window;
using Helper.ViewModel.WindowsManager;

namespace Helper.View.WindowsManager
{
    internal class WindowsManager : IWindowManager
    {
        private readonly Dictionary<IWindowViewModel, IWindow> _viewModelToWindowMap = new();

        private readonly IWindowFactory _windowFactory;

        public WindowsManager(IWindowFactory windowFactory)
        {
            _windowFactory = windowFactory;
        }

        public IWindow Show<T>(T viewModel)
            where T : IWindowViewModel
        {
            var window = _windowFactory.Create(viewModel);

            _viewModelToWindowMap.Add(viewModel, window);

            window.Show();

            return window;
        }

        public void Close<T>(T viewModel)
            where T : IWindowViewModel
        {
            if (_viewModelToWindowMap.TryGetValue(viewModel, out var window))
            {
                window.Close();
                _viewModelToWindowMap.Remove(viewModel);
            }
        }
    }
}
