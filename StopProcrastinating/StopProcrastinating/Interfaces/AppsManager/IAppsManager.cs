using System.Collections.Generic;

namespace StopProcrastinating.Interfaces.AppsManager
{
    public interface IAppsManager
    {
        IEnumerable<IApp> GetInstalledApps();
    }
}
