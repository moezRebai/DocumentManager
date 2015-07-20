using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using DocumentManager.Model;

namespace DocumentManager.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            
            SimpleIoc.Default.Register<RepositoryViewModel>();

            SimpleIoc.Default.Register<DocumentViewModel>();

            SimpleIoc.Default.Register<CommentsViewModel>();

            SimpleIoc.Default.Register<FolderModelsViewModel>();

            SimpleIoc.Default.Register<LegendViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        /// <summary>
        /// Gets the Repository property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public RepositoryViewModel RepositoryInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RepositoryViewModel>();
            }
        }


        /// <summary>
        /// Gets the Repository property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public DocumentViewModel DocumentInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DocumentViewModel>();
            }
        }

        /// <summary>
        /// Gets the Repository property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public CommentsViewModel CommentInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CommentsViewModel>();
            }
        }

        /// <summary>
        /// Gets the Repository property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public FolderModelsViewModel ModelsInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FolderModelsViewModel>();
            }
        }


        /// <summary>
        /// Gets the Repository property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public LegendViewModel LegendInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LegendViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}