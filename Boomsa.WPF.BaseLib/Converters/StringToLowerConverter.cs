using Boomsa.WPF.BaseLib.Converters.Base;

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Converters
{
    /// <summary>
    /// Переводит строку в нижний регистр
    /// </summary>
    [ValueConversion(typeof(string), typeof(string))]
    [MarkupExtensionReturnType(typeof(StringToLowerConverter))]
    class StringToLowerConverter : Converter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string)?.ToLower() ?? "";
        }
    }
}
