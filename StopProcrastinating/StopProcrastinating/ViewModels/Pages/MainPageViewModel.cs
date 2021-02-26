using StopProcrastinating.Interfaces.AppsManager;
using System.Collections.Generic;

namespace StopProcrastinating.ViewModels.Pages
{
    class MainPageViewModel : ViewModelBase
    {
        #region fields

        private IEnumerable<IApp> apps;

        #endregion

        #region constructor/destructor

        public MainPageViewModel()
        {
            Apps = AppContext.AppsManager.GetInstalledApps();
        }

        #endregion

        #region properties

        public IEnumerable<IApp> Apps { get => apps; set => Set(ref apps, value); }

        #endregion
    }
}
