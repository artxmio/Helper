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
                OrderDateAndNumber = new StringBuilder("123"),
                OrderDefinition = new StringBuilder("Graphics Programming with GDI+"),
                PerformerNameAndPosition = new StringBuilder("asdasd"),
            });

            records.Add(new RecordModel()
            {
                ID = 201,
                OrderDateAndNumber = new StringBuilder("123"),
                OrderDefinition = new StringBuilder("Graphics Programming with GDI+"),
                PerformerNameAndPosition = new StringBuilder("asdasd"),
            });

            records.Add(new RecordModel()
            {
                ID = 244,
                OrderDateAndNumber = new StringBuilder("123"),
                OrderDefinition = new StringBuilder("Graphics Programming with GDI+"),
                PerformerNameAndPosition = new StringBuilder("asdasd"),
            });

            return records;
        }
    }
}
