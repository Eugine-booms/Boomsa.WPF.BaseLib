using Boomsa.WPF.BaseLib.Infrastructure.Command.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Boomsa.WPF.BaseLib.Infrastructure.Command
{
    class CloseAppCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
       
    }
}
