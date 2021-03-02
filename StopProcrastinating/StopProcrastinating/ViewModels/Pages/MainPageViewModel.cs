using MvvmCross.Commands;
using MvvmCross.ViewModels;
using StopProcrastinating.Interfaces.AppsManager;
using System.Collections.ObjectModel;

namespace StopProcrastinating.ViewModels.Pages
{
    class MainPageViewModel : MvxViewModel
    {
        #region fields

        private MvxCommand getGrantPermissionCommand;

        private MvxCommand getAppUsageStatsCommand;

        #endregion

        #region methods

        private void GetAppUsageStats()
        {
            foreach (var process in AppContext.AppsManager.GetInstalledApps())
            {
                Apps.Add(process);
            }
        }

        private void GetGrantPermission()
        {
            AppContext.Settings.LaunchSettings();
        }

        #endregion

        #region properties

        public MvxCommand GetGrantPermissionCommand => getGrantPermissionCommand ??= new MvxCommand(GetGrantPermission);

        public MvxCommand GetAppUsageStatsCommand => getAppUsageStatsCommand ??= new MvxCommand(GetAppUsageStats);

        public ObservableCollection<IApp> Apps { get; } = new ObservableCollection<IApp>();

        #endregion
    }
}
