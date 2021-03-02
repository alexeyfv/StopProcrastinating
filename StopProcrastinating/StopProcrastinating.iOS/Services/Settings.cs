using StopProcrastinating.Interfaces;
using StopProcrastinating.iOS.Services;

[assembly: Xamarin.Forms.Dependency(typeof(Settings))]
namespace StopProcrastinating.iOS.Services
{
    public class Settings : ISettings
    {
        #region methods

        public void LaunchSettings()
        {
        }

        #endregion
    }
}
