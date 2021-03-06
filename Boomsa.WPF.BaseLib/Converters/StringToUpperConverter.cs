using Boomsa.WPF.BaseLib.Converters.Base;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Converters
{
    /// <summary>
    /// Переводит строку в верхний регистр
    /// </summary>
    [ValueConversion(typeof(string), typeof(string))]
    [MarkupExtensionReturnType(typeof(StringToUpperConverter))]
    class StringToUpperConverter : Converter
    {
        /// <summary>
        ///  Переводит строку в верхний регистр
        /// </summary>
        /// <param name="value"> Принимаемая строка </param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string)?.ToUpper() ?? "";
        }
    }
}
