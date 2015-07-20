using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DocumentManager.Model;
using GalaSoft.MvvmLight;

namespace DocumentManager.ViewModel
{
    public class LegendViewModel: ViewModelBase
    {
        #region Filed

        private string _model;

        private Document _selectedDocument;
        
        private ObservableCollection<Document> _documentsListCollection;

        #endregion

        #region Properties
        public string Model
        {
            get { return _model; }
            set
            {
                if (value != _model)
                {
                    _model = value;
                    RaisePropertyChanged("Model");
                }
            }
        }

        public Document SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                if (value != _selectedDocument)
                {
                    _selectedDocument = value;
                    RaisePropertyChanged("SelectedDocument");
                }
            }
        }

        public ObservableCollection<Document> DocumentsListCollection
        {
            get { return _documentsListCollection; }
            set
            {
                _documentsListCollection = value;
                SelectedDocument = _documentsListCollection.FirstOrDefault();
                RaisePropertyChanged("DocumentsListCollection");
            }
        }

        #endregion

        #region Commands

        public ICommand ModelCommand { get; private set; }

        #endregion

        #region Constructors

        public LegendViewModel()
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}
