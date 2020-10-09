using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfCustomScrollBar.Converters
{
    public class ScrollBarSizeToMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var size = System.Convert.ToDouble(value, culture);
            var isVertical = System.Convert.ToBoolean(parameter, culture);

            return isVertical ? new Thickness(-size, 0, 0, 0) : new Thickness(0, -size, size, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => Binding.DoNothing;
    }
}
