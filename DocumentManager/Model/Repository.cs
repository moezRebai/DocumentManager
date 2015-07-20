using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DocumentManager.Model
{
    public class Repository : INotifyPropertyChanged
    {
        private string _repositoryName;
        public string RepositoryName
        {
            get
            {
                return _repositoryName;
            }
            set
            {
                _repositoryName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RepositoryName"));
            }
        }

        private ObservableCollection<Document> _documents;
        public ObservableCollection<Document> Documents
        {
            get { return _documents; }
            set
            {
                _documents = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Documents"));
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
        public Repository()
        {
            Documents = new ObservableCollection<Document>();
        }
    }
}
