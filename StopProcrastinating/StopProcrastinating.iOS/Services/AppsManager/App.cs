using StopProcrastinating.Interfaces.AppsManager;
using StopProcrastinating.iOS.Services.AppsManager;
using Xamarin.Forms;

[assembly: Dependency(typeof(App))]
namespace StopProcrastinating.iOS.Services.AppsManager
{
    public class App : IApp
    {
        #region properties

        public string Name { get; }

        #endregion
    }
}
