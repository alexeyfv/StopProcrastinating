using Android.App;
using Android.App.Usage;
using Android.Content;
using StopProcrastinating.Droid.Services.AppsManager;
using StopProcrastinating.Interfaces.AppsManager;
using System;
using System.Collections.Generic;

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
                    list.Add(new App($"App: {item.PackageName ?? string.Empty}; T: {TimeConverter.Convert(item.LastTimeUsed)}"));
                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return list;
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
