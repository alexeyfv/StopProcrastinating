using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StopProcrastinating.ViewModels.Pages
{
    class MainPageViewModel : MvxViewModel
    {
        #region fields

        private MvxCommand getGrantPermissionCommand;

        private MvxCommand getAppUsageStatsCommand;
        private bool isLoading;

        #endregion

        #region methods

        private void GetAppUsageStats()
        {
            try
            {
                Task.Run(() =>
                {
                    IsLoading = true;
                    return AppContext.AppsManager.GetInstalledApps();
                }).ContinueWith(task =>
                {
                    if (task.IsFaulted)
                    {
                        throw task.Exception;
                    }

                    foreach (var process in task.Result)
                    {
                        Apps.Add(new Models.App.App(process));
                    }
                }).ContinueWith(task =>
                {
                    if (task.IsFaulted)
                    {
                        throw task.Exception;
                    }

                    IsLoading = false;
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

        public ObservableCollection<Models.App.App> Apps { get; } = new ObservableCollection<Models.App.App>();

        public bool IsLoading { get => isLoading; set => SetProperty(ref isLoading, value); }

        #endregion
    }
}
