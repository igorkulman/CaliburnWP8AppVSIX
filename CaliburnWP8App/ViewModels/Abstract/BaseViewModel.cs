using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace $safeprojectname$.ViewModels.Abstract
{
    public abstract class BaseViewModel: Screen
    {
        protected readonly INavigationService NavigationService;
        protected readonly IEventAggregator EventAggregator;

        protected BaseViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            NavigationService = navigationService;
            EventAggregator = eventAggregator;
        }
    }
}
