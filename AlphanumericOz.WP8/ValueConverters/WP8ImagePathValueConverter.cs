using System;
using System.Windows.Data;

namespace AlphanumericOz.WP8.ValueConverters
{
    // inspired by http://www.j2i.net/blogEngine/post/2011/09/03/Displaying-an-Image-from-Isolated-Storage.aspx
    public class WP8ImagePathValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;

            if (!(value is string))
                return null;

            string fileName = value.ToString();
            fileName = fileName.Substring(4, fileName.Length - 4);

            return "/Assets/" + fileName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}