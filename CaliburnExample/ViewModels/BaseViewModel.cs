using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CaliburnExample.ViewModels
{
    public abstract class BaseViewModel : Screen
    {
    }

    public abstract class BaseViewModel<TModel> : BaseViewModel
    {
        private TModel _model;

        public TModel Model
        {
            get => _model;
            set
            {
                _model = value;
                NotifyOfPropertyChange();
            }
        }

        public virtual TModel ToModel() => _model;
    }
}
