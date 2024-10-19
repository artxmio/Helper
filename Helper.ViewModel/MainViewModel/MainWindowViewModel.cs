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
                Date = new DateTime(1,2,3).ToString("dd.MM.yyyy"),
                Number = "123",
                Definition = "Graphics Programming with GDI+",
                PerformerName = "asdasd",
                PerformerPosition = "awqe",
            });
            records.Add(new RecordModel()
            {
                ID = 111,
                Date = new DateTime(1, 2, 3).ToString("dd.MM.yyyy"),
                Number = "123",
                Definition = "Graphics Programming with GDI+",
                PerformerName = "asdasd",
                PerformerPosition = "awqe",
            });
            return records;
        }
    }
}