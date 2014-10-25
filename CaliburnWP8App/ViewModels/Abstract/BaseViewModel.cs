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
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        protected BaseViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
        }
    }
}
