using System;
using System.Windows.Data;

namespace it.gui.Converters
{

    /// <summary>
    /// If Value is not NULL then return Visible else return Collapsed
    /// </summary>
    public class NullFalseVisibilityCollapsedConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                bool result = value != null;

                if (result)
                    return "Visible";

                return "Collapsed";
            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
