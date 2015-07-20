using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using DocumentManager.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace DocumentManager.ViewModel
{
    public class DocumentViewModel: ViewModelBase
    {
        #region Filed

        private ObservableCollection<Document> _documentsListCollection;

        private List<string> _listRemarks;

        private Document _selectedDocument;

        private readonly CommentsViewModel _commentViewModel;

        #endregion

        #region Properties
        public Document SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                if (value != _selectedDocument)
                {
                    _selectedDocument = value;
                    SelectedDocumentChanged();
                    RaisePropertyChanged("SelectedDocument");
                }
            }
        }
        public List<string> ListRemarks
        {
            get { return _listRemarks; }
            set
            {
                _listRemarks = value;
                RaisePropertyChanged("ListRemarks");
            }
        }
        public ObservableCollection<Document> DocumentsListCollection
        {
            get { return _documentsListCollection; }
            set
            {
                _documentsListCollection = value;
                RaisePropertyChanged("DocumentsListCollection");
            }
        }

        #endregion

        #region Commands
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand EditCommand { get; private set; }

        #endregion

        #region Constructors

        public DocumentViewModel()
        {
            _commentViewModel = SimpleIoc.Default.GetInstance<CommentsViewModel>();
            AddCommand = new RelayCommand(AddRepository,() => true);
            DeleteCommand = new RelayCommand(DeleteRepository, () => SelectedDocument != null);
            EditCommand = new RelayCommand(EditRepository, () => SelectedDocument != null);
        }

        private void EditRepository()
        {
            
        }

        private void DeleteRepository()
        {
            
        }
        private void AddRepository()
        {
           
        }


        #endregion

        #region Methods

        private void SelectedDocumentChanged()
        {
            _commentViewModel.ListRemarks = SelectedDocument.Remarks;
            ListRemarks = SelectedDocument.Remarks;
        }

        #endregion
    }
}
