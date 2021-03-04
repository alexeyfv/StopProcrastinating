using StopProcrastinating.Interfaces;
using StopProcrastinating.Interfaces.App;
using Xamarin.Forms;

namespace StopProcrastinating
{
    class AppContext
    {
        #region static properties

        public static IAppsManager AppsManager => DependencyService.Get<IAppsManager>();

        public static ISettings Settings => DependencyService.Get<ISettings>();

        #endregion
    }
}
