using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StopProcrastinating.ViewModels
{
    /// <summary>
    /// Base class for all VMs
    /// </summary>
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region methods

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        #region events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
