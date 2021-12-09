using Boomsa.WPF.BaseLib.Infrastructure.Command.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Infrastructure.Command
{
    [MarkupExtensionReturnType(typeof(LambdaCommand))]
    class LambdaCommand : BaseCommand
    {
        private readonly Action <object> execute;
        private readonly Func<object, bool> canExecute;
        /// <summary>
        ///  Команда с делегатами
        /// </summary>
        /// <param name="execute">Выполнение </param>
        /// <param name="canExecute"> Возможность выполнения</param>
        public LambdaCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }
        /// <summary>
        /// Команда с делегатами без параметров
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecuted"></param>
        public LambdaCommand(Action execute, Func<bool> canExecute = null) :
            this(
                execute: p => execute(),
                canExecute: canExecute is null ? (Func<object, bool>)null : p => canExecute())
        { }

        public override void Execute(object parameter)
        {
            execute?.Invoke(parameter);
        }
        public override bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}
