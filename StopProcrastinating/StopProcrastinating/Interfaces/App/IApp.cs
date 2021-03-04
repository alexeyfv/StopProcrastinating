using System;

namespace StopProcrastinating.Interfaces.App
{
    public interface IApp
    {
        /// <summary>
        /// Application label
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Last time application was used
        /// </summary>
        DateTime LastTimeUsed { get; }

        /// <summary>
        /// Application icon
        /// </summary>
        byte[] IconBytes { get; }
    }
}
