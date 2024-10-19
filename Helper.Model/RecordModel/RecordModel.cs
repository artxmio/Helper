using System.Text;

namespace Helper.Model.MainModel
{
    public class RecordModel
    {
        public int ID { get; set; }
        public StringBuilder? Date { get; set; }
        public StringBuilder? Number{ get; set; }
        public StringBuilder? Definition { get; set; }
        public StringBuilder? PerformerName { get; set; }
        public StringBuilder? PerformerPosition { get; set; }
    }   
}
