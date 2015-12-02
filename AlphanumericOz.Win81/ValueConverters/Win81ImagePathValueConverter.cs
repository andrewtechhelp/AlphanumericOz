using System;
using Windows.UI.Xaml.Data;

namespace AlphanumericOz.Win81.ValueConverters
{
    // inspired by http://www.j2i.net/blogEngine/post/2011/09/03/Displaying-an-Image-from-Isolated-Storage.aspx
    public class Win81ImagePathValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return null;

            if (!(value is string))
                return null;

            string fileName = value.ToString();
            fileName = fileName.Substring(4, fileName.Length - 4);

            return "ms-appx:///Assets/" + fileName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}