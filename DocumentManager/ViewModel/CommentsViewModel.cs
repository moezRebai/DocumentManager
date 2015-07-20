using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DocumentManager.Model;
using GalaSoft.MvvmLight;

namespace DocumentManager.ViewModel
{
    public class CommentsViewModel: ViewModelBase
    {
        #region Filed

        private List<string> _listRemarks;

        #endregion

        #region Properties
        public List<string> ListRemarks
        {
            get { return _listRemarks; }
            set
            {
                _listRemarks = value;
                RaisePropertyChanged("ListRemarks");
            }
        }

        #endregion

        #region Commands
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand EditCommand { get; private set; }

        #endregion

        #region Constructors

        public CommentsViewModel()
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}
