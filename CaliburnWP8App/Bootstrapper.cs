using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Controls;
using Caliburn.Micro;
using $safeprojectname$.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace $safeprojectname$
{
    public class Bootstrapper : PhoneBootstrapperBase 
    {
        PhoneContainer container;

        public Bootstrapper()
        {
            LogManager.GetLog = type => new DebugLog(type);
            Initialize();
        }

        protected override void Configure()
        {           
            container = new PhoneContainer();

            if (Execute.InDesignMode)
                return;

            container.RegisterPhoneServices(RootFrame);
                      
            container.PerRequest<MainViewModel>();

            AddCustomConventions();
        }

        static void AddCustomConventions()
        {

            // ... the rest of your conventions
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
