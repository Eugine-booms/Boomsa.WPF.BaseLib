﻿using Boomsa.WPF.BaseLib.Converters.Base;

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Boomsa.WPF.BaseLib.Converters
{
    /// <summary>
    /// выполняет преобразование вида f(x)=x+B;
    /// </summary>
    [ValueConversion(typeof(double), typeof(double))]
    [MarkupExtensionReturnType(typeof(AddConverter))]
    internal class AddConverter : Converter
    {
        public AddConverter() : this(0) { }

        public AddConverter(double b) => B = b;

        [ConstructorArgument("B")]
        public double B { get; set; } = 0;
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
