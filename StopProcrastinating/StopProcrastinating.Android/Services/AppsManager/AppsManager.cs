using Android.Content.PM;
using StopProcrastinating.Droid.Services.AppsManager;
using StopProcrastinating.Interfaces.AppsManager;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppsManager))]
namespace StopProcrastinating.Droid.Services.AppsManager
{
    public class AppsManager : IAppsManager
    {
        #region methods

        public IEnumerable<IApp> GetInstalledApps()
        {

            var apps = Android.App.Application.Context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);

            return apps.Select(app => new App(app.Name ?? string.Empty));
        }

        #endregion
    }
}
