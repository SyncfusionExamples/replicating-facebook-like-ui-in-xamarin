using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace FB_Like_Sample.Converters
{
    public class KeyToFontIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is AboutType)
            {
                switch ((AboutType)value)
                {
                    case AboutType.Education:
                        return "\ue75c";
                    case AboutType.Followers:
                        return "\ue75a";
                    case AboutType.Following:
                        return "\ue755";
                    case AboutType.Joined:
                        return "\ue742";
                    case AboutType.Living:
                        return "\ue729";
                    case AboutType.Native:
                        return "\ue706";
                    case AboutType.Position:
                        return "\ue70e";
                    case AboutType.Work:
                        return "\ue759";
                }
            }

            if (value is MenuItemType)
            {
                switch ((MenuItemType)value)
                {
                    case MenuItemType.Home:
                        return "\ue706";
                    case MenuItemType.Profile:
                        return "\ue70e";
                    case MenuItemType.About:
                        return "\ue707";
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
