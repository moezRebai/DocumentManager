using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace DocumentManager.Helpers
{
    public class ModelClass : ViewModelBase
    {
        #region Filed

        private string _model;

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


        #endregion

        #region Commands

        public ICommand ModelCommand { get; private set; }

        #endregion

        #region Constructors

        public ModelClass()
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}
