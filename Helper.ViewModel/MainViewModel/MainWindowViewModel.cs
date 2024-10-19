using Helper.Model.MainModel;
using System.Text;

namespace Helper.ViewModel.MainViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public List<RecordModel>? records { get; }

        public MainWindowViewModel()
        {
            records = GenerateRecords();
        }

        private List<RecordModel> GenerateRecords()
        {
            List<RecordModel> records = new();

            records.Add(new RecordModel()
            {
                ID = 101,
                Date = new StringBuilder (new DateTime(1,2,3).ToString("dd.MM.yyyy")),
                Number = new StringBuilder("123"),
                Definition = new StringBuilder("Graphics Programming with GDI+"),
                PerformerName = new StringBuilder("asdasd"),
                PerformerPosition = new StringBuilder("awqe"),
            });
            return records;
        }
    }
}