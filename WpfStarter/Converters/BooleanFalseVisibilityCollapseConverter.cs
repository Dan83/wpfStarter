using System;
using System.Windows.Data;

namespace it.gui.Converters
{
    /// <summary>
    /// If Value is False then return Visible else return Collapsed
    /// </summary>
    public class BooleanFalseVisibilityCollapseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                bool valueTarget = false;
                bool.TryParse(value.ToString(), out valueTarget);

                if (!valueTarget)
                    return "Visible";

                return "Collapsed";

            }
            catch (Exception ex)
            {
                return "Collapsed";

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return value;
        }
    }
}
