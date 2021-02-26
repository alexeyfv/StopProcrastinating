using StopProcrastinating.Droid.Services.AppsManager;
using StopProcrastinating.Interfaces.AppsManager;
using Xamarin.Forms;

[assembly: Dependency(typeof(App))]
namespace StopProcrastinating.Droid.Services.AppsManager
{
    public class App : IApp
    {
        #region constructor/destructor

        public App(string name)
        {
            Name = name;
        }

        #endregion

        #region properties

        public string Name { get; }

        #endregion
    }
}
