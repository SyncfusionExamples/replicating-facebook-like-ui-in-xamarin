using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace FB_Like_Sample.Converters
{
    public class FB_PostTypeVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                return true;
            }
            PostType postType = (PostType)value;
            switch (parameter.ToString())
            {
                case "1":
                    if(postType==PostType.MessageOnly)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "2":
                    if (postType == PostType.Picture)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "3":
                    if (postType == PostType.Video)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
