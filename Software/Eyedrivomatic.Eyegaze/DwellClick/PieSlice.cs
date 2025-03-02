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


// Most of this class is borrowed from https://wpf.2000things.com/2014/09/05/1152-a-custom-pie-slice-shape/

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Eyedrivomatic.Eyegaze.DwellClick
{
    public class PieSlice : Shape
    {
        private static PropertyMetadata startAngleMetadata = new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender, null, CoerceAngle);
        public static readonly DependencyProperty StartAngleProperty =
            DependencyProperty.Register(nameof(StartAngle), typeof(double), typeof(PieSlice), startAngleMetadata);

        /// <summary>
        /// The angle of the leading clockwise edge of the pie slice.
        /// </summary>
        public double StartAngle
        {
            get => (double)GetValue(StartAngleProperty);
            set => SetValue(StartAngleProperty, value);
        }


        /// <summary>
        /// The angle of the leading counter-clockwise edge of the pie slice.
        /// </summary>
        public double EndAngle
        {
            get => (double)GetValue(EndAngleProperty);
            set => SetValue(EndAngleProperty, value);
        }

        private static PropertyMetadata endAngleMetadata = new FrameworkPropertyMetadata(90.0, FrameworkPropertyMetadataOptions.AffectsRender, null, CoerceAngle);
        public static readonly DependencyProperty EndAngleProperty =
            DependencyProperty.Register(nameof(EndAngle), typeof(double), typeof(PieSlice), endAngleMetadata);

        private static object CoerceAngle(DependencyObject depObj, object baseVal)
        {
            double angle = (double)baseVal;
            return Math.Min(angle, 360d);
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                var maxWidth = Math.Max(0.0, RenderSize.Width - StrokeThickness);
                var maxHeight = Math.Max(0.0, RenderSize.Height - StrokeThickness);

                var xStart = maxWidth / 2.0 * Math.Cos(StartAngle * Math.PI / 180.0);
                var yStart = maxHeight / 2.0 * Math.Sin(StartAngle * Math.PI / 180.0);

                var xEnd = maxWidth / 2.0 * Math.Cos(EndAngle * Math.PI / 180.0);
                var yEnd = maxHeight / 2.0 * Math.Sin(EndAngle * Math.PI / 180.0);

                StreamGeometry geom = new StreamGeometry();
                using (StreamGeometryContext ctx = geom.Open())
                {
                    ctx.BeginFigure(
                        new Point((RenderSize.Width / 2.0) + xStart,
                                  (RenderSize.Height / 2.0) - yStart),
                        true,   // Filled
                        true);  // Closed
                    ctx.ArcTo(
                        new Point((RenderSize.Width / 2.0) + xEnd,
                                  (RenderSize.Height / 2.0) - yEnd),
                        new Size(maxWidth / 2.0, maxHeight / 2),
                        0.0,     // rotationAngle
                        (EndAngle - StartAngle) > 180,   // greater than 180 deg?
                        SweepDirection.Counterclockwise,
                        true,    // isStroked
                        false);
                    ctx.LineTo(new Point((RenderSize.Width / 2.0), (RenderSize.Height / 2.0)), true, false);
                }

                return geom;
            }
        }
    }
}
