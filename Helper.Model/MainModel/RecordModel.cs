using System.Text;

namespace Helper.Model.MainModel
{
    public class RecordModel
    {
        public int ID { get; set; }
        public StringBuilder? OrderDateAndNumber { get; set; }
        public StringBuilder? OrderDefinition { get; set; }
        public StringBuilder? PerformerNameAndPosition { get; set; }
    }   
}
