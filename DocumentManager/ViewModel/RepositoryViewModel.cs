using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DocumentManager.Model;
using DocumentManager.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace DocumentManager.ViewModel
{
    public class RepositoryViewModel : ViewModelBase
    {
        #region Filed

        private ObservableCollection<Repository> _repositoriesListCollection;

        private Repository _selectedFolder;

        private readonly DocumentViewModel _documentViewModel;

        private readonly LegendViewModel _legendViewModel;

        private readonly FolderModelsViewModel _modelViewModel;

        #endregion

        #region Properties
        public Repository SelectedFolder
        {
            get { return _selectedFolder; }
            set
            {
                if (value != _selectedFolder)
                {
                    _selectedFolder = value;

                    RaisePropertyChanged("SelectedFolder");

                    SelectedFolderChanged();
                }
            }
        }
        private void SelectedFolderChanged()
        {
            _documentViewModel.DocumentsListCollection = SelectedFolder.Documents;
            _legendViewModel.DocumentsListCollection = SelectedFolder.Documents;
            _modelViewModel.ModelsListCollection = ToObservableCollection(SelectedFolder.Documents.Where(x => x.IsModel));
        }
        public ObservableCollection<Repository> RepositoriesListCollection
        {
            get { return _repositoriesListCollection; }
            set
            {
                _repositoriesListCollection = value;
                RaisePropertyChanged("RepositoriesListCollection");
            }
        }

        #endregion

        #region Commands
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand EditCommand { get; private set; }

        #endregion

        #region Constructors

        public RepositoryViewModel()
        {
            InitializeRepositories();
            AddCommand = new RelayCommand(AddRepository, () => true);
            DeleteCommand = new RelayCommand(DeleteRepository, () => SelectedFolder != null);
            EditCommand = new RelayCommand(EditRepository, () => SelectedFolder != null);
            _documentViewModel = SimpleIoc.Default.GetInstance<DocumentViewModel>();
            _legendViewModel = SimpleIoc.Default.GetInstance<LegendViewModel>();
            _modelViewModel = SimpleIoc.Default.GetInstance<FolderModelsViewModel>();
        }

        private void EditRepository()
        {
            var newFolder = new AddNewRepository();
            newFolder.ShowDialog();
        }

        private void DeleteRepository()
        {
            RepositoriesListCollection.Remove(SelectedFolder);
        }
        private void AddRepository()
        {
            var newFolder = new AddNewRepository();
            newFolder.ShowDialog();
            if (!string.IsNullOrEmpty(newFolder.FolderName))
            {
                RepositoriesListCollection.Add(new Repository { RepositoryName = newFolder.FolderName });
            }
        }

        #endregion

        #region Methods
        private void InitializeRepositories()
        {
            RepositoriesListCollection = new ObservableCollection<Repository>
            {
                new Repository {RepositoryName = "Music" , Documents = new ObservableCollection<Document>
                {
                    new Document{Name = "Music", Extension = ".mp3", Version = "4.51", Remarks = new List<string>{"Test comments", "Test 2"}},
                     new Document{Name = "Image", Extension = ".png", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                      new Document{Name = "Pdf Doc", Extension = ".pdf", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                       new Document{Name = "Text Doc", Extension = ".text", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                        new Document{Name = "Word Doc", Extension = ".doc", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}}
                }},
                new Repository {RepositoryName = "Images",  Documents = new ObservableCollection<Document>
                {
                                        new Document{Name = "Music", Extension = ".mp3", Version = "4.51", Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                     new Document{Name = "Image", Extension = ".png", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                      new Document{Name = "Pdf Doc", Extension = ".pdf", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                       new Document{Name = "Text Doc", Extension = ".text", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                        new Document{Name = "Word Doc", Extension = ".doc", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}}
                }},
                new Repository {RepositoryName = "Documents" , Documents = new ObservableCollection<Document>
                {
                                        new Document{Name = "Music", Extension = ".mp3", Version = "4.51", Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                     new Document{Name = "Image", Extension = ".png", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                      new Document{Name = "Pdf Doc", Extension = ".pdf", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                       new Document{Name = "Text Doc", Extension = ".text", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                        new Document{Name = "Word Doc", Extension = ".doc", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                }},
                new Repository {RepositoryName = "Apps", Documents = new ObservableCollection<Document>
                {
                                       new Document{Name = "Music", Extension = ".mp3", Version = "4.51", Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                     new Document{Name = "Image", Extension = ".png", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                      new Document{Name = "Pdf Doc", Extension = ".pdf", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                       new Document{Name = "Text Doc", Extension = ".text", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                        new Document{Name = "Word Doc", Extension = ".doc", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                }},
                new Repository {RepositoryName = "Others" , Documents = new ObservableCollection<Document>
                {
                                        new Document{Name = "Music", Extension = ".mp3", Version = "4.51", Remarks = new List<string>{"Test comments", "Test 2"}},
                     new Document{Name = "Image", Extension = ".png", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                      new Document{Name = "Pdf Doc", Extension = ".pdf", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                       new Document{Name = "Text Doc", Extension = ".text", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}},
                        new Document{Name = "Word Doc", Extension = ".doc", Version = "4.51",  Remarks = new List<string>{"Test comments", "Test 2"}, IsModel = true},
                }},
                new Repository {RepositoryName = "Videos"}
            };
        }


        public static ObservableCollection<T> ToObservableCollection<T>(IEnumerable<T> collection)
        {
            return new ObservableCollection<T>(collection);
        }

        #endregion
    }
}
