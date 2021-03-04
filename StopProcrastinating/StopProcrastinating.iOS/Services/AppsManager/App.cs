using StopProcrastinating.Interfaces.App;
using StopProcrastinating.iOS.Services.AppsManager;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(App))]
namespace StopProcrastinating.iOS.Services.AppsManager
{
    public class App : IApp
    {
        public string Label { get; }
        public DateTime LastTimeUsed { get; }
        public byte[] IconBytes { get; }
    }
}
