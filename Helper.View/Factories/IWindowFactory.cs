using Helper.ViewModel.Window;

namespace Helper.View.Factories
{
    public interface IWindowFactory
    {
        public IWindow Create<T>(T viewModel)
            where T : IWindowViewModel;
    }
}
