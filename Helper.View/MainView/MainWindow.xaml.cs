using Helper.ViewModel.MainViewModel;

namespace Helper.View.MainView
{
    public partial class MainWindow : IMainWindow
    {
        public MainWindow(IMainWindowViewModel viewModel) 
        {
            InitializeComponent();

            DataContext = viewModel; 
        }
    }
}