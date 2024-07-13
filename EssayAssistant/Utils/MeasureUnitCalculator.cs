using System;
using System.ComponentModel;
using System.Drawing;
using Units = Microsoft.Office.Interop.Word.WdMeasurementUnits;

namespace EssayAssistant.Utils
{
    internal static class MeasureUnitCalculator
    {
        private static readonly double dpiX;
        private static readonly double dpiY;

        static MeasureUnitCalculator()
        {
            var ratio = 4.0 / 3.0; // Magic Number
            using (var g = Graphics.FromHwnd(IntPtr.Zero))
            {
                dpiX = g.DpiX / ratio;
                dpiY = g.DpiY / ratio;
            }
        }

        private static double LengthToPoints(double value, Units unit, double dpi)
        {
            switch (unit)
            {
                case Units.wdCentimeters:
                    return value * dpi / 2.54;

                case Units.wdMillimeters:
                    return value * dpi / 25.4;

                case Units.wdInches:
                    return value * dpi;

                case Units.wdPoints:
                    return value;

                case Units.wdPicas:
                    return value * dpi / 72;

                default:
                    throw new InvalidEnumArgumentException(nameof(unit), (int)unit, typeof(Units));
            }
        }

        private static double PointsToLength(double value, Units unit, double dpi)
        {
            switch (unit)
            {
                case Units.wdCentimeters:
                    return value * 2.54 / dpi;

                case Units.wdMillimeters:
                    return value * 25.4 / dpi;

                case Units.wdInches:
                    return value / dpi;

                case Units.wdPoints:
                    return value;

                case Units.wdPicas:
                    return value * 72 / dpi;

                default:
                    throw new InvalidEnumArgumentException(nameof(unit), (int)unit, typeof(Units));
            }
        }

        public static double HeightToPoints(double value, Units unit = Units.wdCentimeters) =>
            LengthToPoints(value, unit, dpiY);

        public static double WidthToPoints(double value, Units unit = Units.wdCentimeters) =>
            LengthToPoints(value, unit, dpiX);

        public static double PointsToHeight(double value, Units unit = Units.wdCentimeters) =>
            PointsToLength(value, unit, dpiY);

        public static double PointsToWidth(double value, Units unit = Units.wdCentimeters) =>
            PointsToLength(value, unit, dpiX);
    }
}
