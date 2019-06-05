using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace NewDesignTestApp.AnimationTrigger
{
    public class IsLikeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (string)value;
            return ImageSource.FromFile(path);

            //switch (value)
            //{
            //    case "favorite.png":
            //        return "unfavorite.png";
            //    //case EnumMessage.BadRequest:
            //    //    return "The request had bad syntax or was inherently impossible to be satisfied.";
            //    //case EnumMessage.NotFound:
            //    //    return "The requested URL was not found on this server";
            //    //case EnumMessage.SystemError:
            //    //    return "Somthing wrong with this server, Please try after some time.";
            //}
            //return "";

            //if (value == "favorite.png")
            //{

            //}
            //var path = value as string;
            //var postfix = parameter as string;

            //if (string.IsNullOrEmpty(postfix) || string.IsNullOrEmpty(path))
            //    return value;

            //return path + postfix;
        }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
