﻿//	Copyright (c) 2018 Eyedrivomatic Authors
//	
//	This file is part of the 'Eyedrivomatic' PC application.
//	
//	This program is intended for use as part of the 'Eyedrivomatic System' for 
//	controlling an electric wheelchair using soley the user's eyes. 
//	
//	Eyedrivomaticis distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  


using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using NullGuard;

namespace Eyedrivomatic.Infrastructure
{
    public class PathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, [AllowNull]  object parameter, CultureInfo culture)
        {
            var converter = new ImageSourceConverter();
            return converter.ConvertFromString(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, [AllowNull]  object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
