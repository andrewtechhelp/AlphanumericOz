using Cirrious.CrossCore.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AlphanumericOz.Core.ValueConverters
{
    public class AndroidImageUrlValueConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName = value.ToString();
            resourceName = resourceName.Remove(resourceName.Length - 4, 4);
            return resourceName;
        }
    }
}
