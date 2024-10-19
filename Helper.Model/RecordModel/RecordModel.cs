using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Helper.Model.MainModel
{
    public class RecordModel : INotifyPropertyChanged
    {
        #region
        private int _id;
        private string? _date;
        private string? _number;
        private string? _definition;
        private string? _performerName;
        private string? _performerPosition;
        #endregion

        #region
        public int ID 
        {
            get
            {
                return this._id;
            } 
            set
            {
                this._id = value;
                OnPropertyChanged("_id");
            } 
        }
        public string? Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
                OnPropertyChanged("_date");
            }
        }
        public string? Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
                OnPropertyChanged("_number");
            }
        }
        public string? Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                this._definition = value;
                OnPropertyChanged("_definition");
            }
        }
        public string? PerformerName
        {
            get
            {
                return this._performerName;
            }
            set
            {
                this._performerName = value;
                OnPropertyChanged("_performerName");
            }
        }
        public string? PerformerPosition
        {
            get
            {
                return this._performerPosition;
            }
            set
            {
                this._performerPosition = value;
                OnPropertyChanged("_performerName");
            }
        }
        #endregion
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }   
}
