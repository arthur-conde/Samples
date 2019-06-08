using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaliburnExample.Models;

namespace CaliburnExample.ViewModels
{
    public class ChildViewModel : BaseViewModel<ChildModel>
    {
        private string _string1, _string2;

        public string String1
        {
            get => _string1;
            set { _string1 = value; NotifyOfPropertyChange(); }
        }

        public string String2
        {
            get => _string2;
            set { _string2 = value; NotifyOfPropertyChange(); }
        }

        public ChildViewModel(ChildModel model)
        {
            Model = model;

            String1 = model.String1;
            String2 = model.String2;
        }

        public override ChildModel ToModel()
        {
            return new ChildModel()
            {
                String1 = String1,
                String2 = String2,
            };
        }
    }
}
