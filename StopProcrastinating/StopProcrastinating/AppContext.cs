using StopProcrastinating.Interfaces.AppsManager;
using Xamarin.Forms;

namespace StopProcrastinating
{
    class AppContext
    {
        #region static properties

        public static IAppsManager AppsManager => DependencyService.Get<IAppsManager>();

        #endregion
    }
}
