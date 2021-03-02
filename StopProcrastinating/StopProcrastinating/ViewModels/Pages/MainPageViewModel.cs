using MvvmCross.ViewModels;
using StopProcrastinating.Interfaces.AppsManager;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StopProcrastinating.ViewModels.Pages
{
    class MainPageViewModel : MvxViewModel
    {
        #region fields

        private ObservableCollection<IApp> apps;

        #endregion

        #region constructor/destructor

        public MainPageViewModel()
        {
            Apps = new ObservableCollection<IApp>();
        }

        #endregion

        #region properties

        public ObservableCollection<IApp> Apps { get => apps; set => SetProperty(ref apps, value); }

        #endregion
    }
}
