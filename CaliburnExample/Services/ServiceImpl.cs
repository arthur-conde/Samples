using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CaliburnExample.Services.Contracts;

namespace CaliburnExample.Services
{
    public class ServiceImpl : IService
    {
        public void DoSomething()
        {
            MessageBox.Show("Hello!", "MessageBox.Show", MessageBoxButton.OK, MessageBoxImage.Information,
                MessageBoxResult.OK, MessageBoxOptions.None);
        }
    }
}
