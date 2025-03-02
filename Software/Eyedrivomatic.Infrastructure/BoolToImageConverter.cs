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
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using NullGuard;

namespace Eyedrivomatic.Infrastructure
{
    public class BoolToImageConverter : Freezable, IValueConverter
    {
        public static readonly DependencyProperty ImageIfTrueProperty =
            DependencyProperty.Register(nameof(ImageIfTrue), typeof(ImageSource), typeof(BoolToImageConverter), new UIPropertyMetadata(null));
        public ImageSource ImageIfTrue
        {
            get => (ImageSource)GetValue(ImageIfTrueProperty);
            set => SetValue(ImageIfTrueProperty, value);
        }

        public static readonly DependencyProperty ImageIfFalseProperty =
            DependencyProperty.Register(nameof(ImageIfFalse), typeof(ImageSource), typeof(BoolToImageConverter), new UIPropertyMetadata(null));
        public ImageSource ImageIfFalse
        {
            get => (ImageSource)GetValue(ImageIfFalseProperty);
            set => SetValue(ImageIfFalseProperty, value);
        }

        [return: AllowNull]
        public object Convert(object value, Type targetType, [AllowNull] object parameter, CultureInfo culture)
        {
            return System.Convert.ToBoolean(value) ? ImageIfTrue : ImageIfFalse;
        }

        public object ConvertBack(object value, Type targetType, [AllowNull] object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        protected override Freezable CreateInstanceCore()
        {
            return new BoolToImageConverter();
        }
    }
}
