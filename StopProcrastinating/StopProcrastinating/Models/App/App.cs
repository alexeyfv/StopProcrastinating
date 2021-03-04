using StopProcrastinating.Interfaces.App;
using System;
using System.IO;
using Xamarin.Forms;

namespace StopProcrastinating.Models.App
{
    class App : IApp
    {
        #region constructor/destructor

        public App(IApp app)
        {
            Label = app.Label;
            LastTimeUsed = app.LastTimeUsed;
            IconBytes = app.IconBytes;
            Icon = ImageSource.FromStream(() => new MemoryStream(IconBytes));
        }

        #endregion

        #region properties

        public string Label { get; }

        public DateTime LastTimeUsed { get; }

        public byte[] IconBytes { get; }

        public ImageSource Icon { get; }

        #endregion
    }
}
