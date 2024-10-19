using Helper.Model.Data;
using Helper.Model.MainModel;
using System.Text;

namespace Helper.ViewModel.MainViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private ApplicationContex _db;

        public List<RecordModel>? Records { get; }

        public MainWindowViewModel()
        {
            
        }
    }
}