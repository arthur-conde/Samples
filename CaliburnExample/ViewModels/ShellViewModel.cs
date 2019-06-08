using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnExample.Models;

namespace CaliburnExample.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private ChildViewModel _child;

        private IWindowManager WindowManager;

        public ChildViewModel Child
        {
            get => _child;
            set { _child = value; NotifyOfPropertyChange();}
        }

        public ShellViewModel(IWindowManager windowManager)
        {
            WindowManager = windowManager;

            Child = new ChildViewModel(new ChildModel());
        }

        public void ShowChild()
        {
            // How do I 
            WindowManager.ShowDialog(new WrapperViewModel(Child.ToModel(), null));
        }
    }
}
