﻿// Copyright (c) 2016 Eyedrivomatic Authors
//
// This file is part of the 'Eyedrivomatic' PC application.
//
//    This program is intended for use as part of the 'Eyedrivomatic System' for 
//    controlling an electric wheelchair using soley the user's eyes. 
//
//    Eyedrivomatic is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Eyedrivomatic is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Eyedrivomatic.  If not, see <http://www.gnu.org/licenses/>.


using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Eyedrivomatic.Infrastructure;

namespace Eyedrivomatic.Configuration
{
    public interface IAppearanceConfigurationService : INotifyPropertyChanged
    {
        bool HideMouseCursor { get; set; }

        ThemeColorsResourceDictionary ThemeColors { get; set; }
        ThemeImagesResourceDictionary ThemeImages { get; set; }
        ThemeStylesResourceDictionary ThemeStyles { get; set; }

        IList<ThemeColorsResourceDictionary> AvailableThemeColors { get; }
        IList<ThemeImagesResourceDictionary> AvailableThemeImages { get; }
        IList<ThemeStylesResourceDictionary> AvailableThemeStyles { get; }

        CultureInfo CurrentCulture { get; set; }
        IList<CultureInfo> AvailableCultures { get; }

        void Save();
        bool HasChanges { get; }
    }
}
