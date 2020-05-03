using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotos.Windows.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        WelcomeViewModel _welcomeVM;

        public ShellViewModel(WelcomeViewModel welcomeViewModel)
        {
            _welcomeVM = welcomeViewModel;
            ActivateItem(_welcomeVM);
        }
    }
}
