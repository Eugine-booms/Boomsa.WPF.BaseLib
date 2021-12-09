using Boomsa.WPF.BaseLib.Infrastructure.Command;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.ViewModel.Base
{
    [MarkupExtensionReturnType(typeof(ViewModelBase))]
    public abstract class ViewModelBase : MarkupExtension, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool Set<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(property, value)) return false;
            property = value;
            return true;
        }
        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}
