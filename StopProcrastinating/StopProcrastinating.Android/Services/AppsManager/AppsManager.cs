using Android.App;
using Android.App.Usage;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Graphics.Drawables;
using StopProcrastinating.Droid.Services.AppsManager;
using StopProcrastinating.Interfaces.App;
using System;
using System.Collections.Generic;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(AppsManager))]
namespace StopProcrastinating.Droid.Services.AppsManager
{
    public class AppsManager : IAppsManager
    {
        #region methods

        public IEnumerable<IApp> GetInstalledApps()
        {
            var list = new List<IApp>();

            try
            {
                var usageStatsManager = Application.Context.GetSystemService(Context.UsageStatsService) as UsageStatsManager;

                long endTime = TimeConverter.Convert(DateTime.UtcNow);
                long beginTime = endTime - 1000 * 10;
                
                var stats = usageStatsManager.QueryUsageStats(UsageStatsInterval.Weekly, beginTime, endTime);

                foreach (var item in stats)
                {
                    var applicationInfo = Application.Context.PackageManager.GetApplicationInfo(item.PackageName, PackageInfoFlags.MatchAll);
                    var applicationLabel = Application.Context.PackageManager.GetApplicationLabel(applicationInfo);
                    var applicationIcon = Application.Context.PackageManager.GetApplicationIcon(applicationInfo);
                    var image = GetImage(applicationIcon);
                    var lastTimeUsed = TimeConverter.Convert(item.LastTimeUsed);

                    list.Add(new App()
                    {
                        Label = applicationLabel,
                        IconBytes = image,
                        LastTimeUsed = lastTimeUsed
                    });
                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return list;
        }

        private static byte[] GetImage(Drawable applicationIcon)
        {
            if (applicationIcon is BitmapDrawable bitmapDrawable)
            {
                using var stream = new MemoryStream();
                bitmapDrawable.Bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
                return stream.ToArray();
            }

            return null;
        }

        class TimeConverter
        {
            private static DateTime StartTime { get; } = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            public static long Convert(DateTime time) => 
                (long)(time - StartTime).TotalMilliseconds;

            public static DateTime Convert(long time) => StartTime.AddMilliseconds(time);
        }

        #endregion
    }
}
