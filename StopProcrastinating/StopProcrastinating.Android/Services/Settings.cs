using Android.App;
using Android.Content;
using StopProcrastinating.Droid.Services;
using StopProcrastinating.Interfaces;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(Settings))]
namespace StopProcrastinating.Droid.Services
{
    public class Settings : ISettings
    {
        #region methods

        public void LaunchSettings()
        {
            try
            {
                var intent = new Intent(Android.Provider.Settings.ActionUsageAccessSettings);
                intent.AddFlags(ActivityFlags.NewTask);
                Application.Context.StartActivity(intent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion
    }
}
