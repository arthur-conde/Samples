using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnExample.Models;

namespace CaliburnExample.ViewModels
{
    public class WrapperViewModel : BaseViewModel
    {
        private ChildViewModel _child;
        private IServiceProvider MyService;


        public ChildViewModel Child
        {
            get => _child;
            set { _child = value; NotifyOfPropertyChange(); }
        }

        public WrapperViewModel(IServiceProvider provider)
        {
            MyService = provider;
        }

        public WrapperViewModel(ChildModel model, IServiceProvider provider)
        {
            Child = new ChildViewModel(model);
            MyService = provider;
        }
    }
}
