using System;
using System.Windows.Data;

namespace it.gui.Converters
{

    /// <summary>
    /// If Value is True then return Visible else return Hidden
    /// </summary>
    public class BooleanTrueVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                bool valueTarget = false;
                bool.TryParse(value.ToString(), out valueTarget);

                if (valueTarget)
                    return "Visible";

                return "Hidden";

            }
            catch (Exception ex)
            {
                return "Hidden";

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return value;
        }
    }
}
