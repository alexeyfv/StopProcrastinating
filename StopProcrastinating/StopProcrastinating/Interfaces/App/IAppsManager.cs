using System.Collections.Generic;

namespace StopProcrastinating.Interfaces.App
{
    public interface IAppsManager
    {
        IEnumerable<IApp> GetInstalledApps();
    }
}
