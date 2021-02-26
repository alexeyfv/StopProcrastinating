using StopProcrastinating.Interfaces.AppsManager;
using StopProcrastinating.iOS.Services.AppsManager;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppsManager))]
namespace StopProcrastinating.iOS.Services.AppsManager
{
    public class AppsManager : IAppsManager
    {
        #region methods

        public IEnumerable<IApp> GetInstalledApps()
        {
            return null;
        }

        #endregion
    }
}
