using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Infrastructure.Command.Base
{
    [MarkupExtensionReturnType(typeof(BaseCommand))]
    [ContentProperty("Executable")]
    abstract class  BaseCommand : MarkupExtension, ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }





        public virtual bool CanExecute(object parameter) =>true;


        public abstract void Execute(object parameter);
        
    }
}
