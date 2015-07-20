using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DocumentManager.Model;
using GalaSoft.MvvmLight;

namespace DocumentManager.ViewModel
{
    public class FolderModelsViewModel: ViewModelBase
    {
        #region Filed

        private ObservableCollection<Document> _modelsListCollection;

        private Document _selectedModel;

        #endregion

        #region Properties

        public Document SelectedModel
        {
            get { return _selectedModel; }
            set
            {
                if (value != _selectedModel)
                {
                    _selectedModel = value;
                    RaisePropertyChanged("SelectedModel");
                }
            }
        }
        public ObservableCollection<Document> ModelsListCollection
        {
            get { return _modelsListCollection; }
            set
            {
                _modelsListCollection = value;
                UpdateModelListCollection();
                RaisePropertyChanged("ModelsListCollection");
            }
        }

        private void UpdateModelListCollection()
        {
            ModelsListCollection.Add(new Document{Name = "New", IsModel = true, Extension = ".New"});
            ModelsListCollection.Add(new Document { Name = "E-mail", IsModel = true, Extension = ".Email" });
        }

        #endregion

        #region Commands
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand EditCommand { get; private set; }

        #endregion

        #region Constructors

        public FolderModelsViewModel()
        {

        }


        #endregion

        #region Methods

        #endregion
    }
}
