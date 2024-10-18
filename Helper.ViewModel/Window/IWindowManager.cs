using Helper.ViewModel.Window;
using System.Windows;

namespace Helper.ViewModel.WindowsManager
{
    public interface IWindowManager
    {
        IWindow Show<T>(T viewModel)
            where T : IWindowViewModel;

        void Close<T>(T viewModel)
            where T : IWindowViewModel;
    }
}
