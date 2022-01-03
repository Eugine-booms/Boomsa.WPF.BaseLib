using Boomsa.WPF.BaseLib.Converters.Base;

using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Converters
{
    [ValueConversion(typeof(object), typeof(object))]
    [MarkupExtensionReturnType(typeof(LinearConverter))]
    internal class DebugConverter : Converter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }
    }
}
