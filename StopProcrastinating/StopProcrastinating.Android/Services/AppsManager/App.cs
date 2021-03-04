using StopProcrastinating.Droid.Services.AppsManager;
using StopProcrastinating.Interfaces.App;
using System;
using Xamarin.Forms;


[assembly: Dependency(typeof(App))]
namespace StopProcrastinating.Droid.Services.AppsManager
{
    public class App : IApp
    {
        public string Label { get; set; }
        public DateTime LastTimeUsed { get; set; }
        public byte[] IconBytes { get; set; }
    }
}
