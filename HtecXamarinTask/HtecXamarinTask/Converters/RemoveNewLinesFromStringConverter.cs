using System;
using System.Globalization;
using Xamarin.Forms;

namespace HtecXamarinTask.Converters
{
    public class RemoveNewLinesFromStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Replace("\n", " ");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("RemoveNewLinesFromStringConverter does not have implementation for ConvertBack method.");
        }
    }
}
