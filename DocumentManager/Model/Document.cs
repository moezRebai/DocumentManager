using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Documents;

namespace DocumentManager.Model
{
    public class Document : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        private string _version;
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Version"));
            }
        }

        private string _extension;
        public string Extension
        {
            get
            {
                return _extension;
            }
            set
            {
                _extension = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Extension"));
            }
        }

        private DateTime _dateCreation;
        public DateTime DateCreation
        {
            get { return _dateCreation; }
            set
            {
                _dateCreation = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DateCreation"));
            }
        }

        private DateTime _modificationDate;
        public DateTime ModificationDate
        {
            get { return _modificationDate; }
            set
            {
                _modificationDate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ModificationDate"));
            }
        }

        private string _createdBy;
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                _createdBy = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CreatedBy"));
            }
        }

        private bool _isModel;
        public bool IsModel
        {
            get { return _isModel; }
            set
            {
                _isModel = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsModel"));
            }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Url"));
            }
        }

        private List<string> _remarks;
        public List<string> Remarks
        {
            get { return _remarks; }
            set
            {
                _remarks = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Remarks"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
