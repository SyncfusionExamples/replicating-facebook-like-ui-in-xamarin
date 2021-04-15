using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace FB_Like_Sample.Converters
{
    public class StringToImageResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is ReactionType)
            {
                switch ((ReactionType)value)
                {
                    case ReactionType.Angry:
                        value = "Angry.png";
                        break;
                    case ReactionType.Happy:
                        value = "Happy.png";
                        break;
                    case ReactionType.Sad:
                        value = "Sad.png";
                        break;
                    case ReactionType.Neutral:
                        value = "Neutral.png";
                        break;
                    case ReactionType.Wonder:
                        value = "Wonder.png";
                        break;
                }
            }
            else if(parameter is string)
            {
                value = (string)parameter;
            }

            string resource = $"FB_Like_Sample.Images." + (string)value;

            return ImageSource.FromResource(resource, typeof(StringToImageResourceConverter).GetTypeInfo().Assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
