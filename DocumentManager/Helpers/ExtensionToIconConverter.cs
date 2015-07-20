using System;
using System.Globalization;
using System.Windows.Data;

namespace DocumentManager.Helpers
{
    public class ExtensionToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return @"/DocumentManager;component/Images/unknown.png";
            var extension = (string)value;

            switch (extension)
            {
                case ".doc":
                    return @"/DocumentManager;component/Images/doc.png";
                case ".mp3":
                    return @"/DocumentManager;component/Images/mp3.png";
                case ".xls":
                    return @"/DocumentManager;component/Images/xls.png";
                case ".pdf":
                    return @"/DocumentManager;component/Images/pdf.png";
                case ".txt":
                    return @"/DocumentManager;component/Images/txt.png";
                case ".png":
                    return @"/DocumentManager;component/Images/png.png";
                case ".New":
                    return @"/DocumentManager;component/Images/NewDoc.png";
                case ".Email":
                    return @"/DocumentManager;component/Images/Email.png";
                default:
                    return @"/DocumentManager;component/Images/unknown.png";
            }
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
