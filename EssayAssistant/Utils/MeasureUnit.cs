using System;
using System.ComponentModel;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Utils
{
    internal static class MeasureUnit
    {
        private static readonly double dpiX;
        private static readonly double dpiY;

        static MeasureUnit()
        {
            var ratio = 4.0 / 3.0; // Magic Number
            using (var g = Graphics.FromHwnd(IntPtr.Zero))
            {
                dpiX = g.DpiX / ratio;
                dpiY = g.DpiY / ratio;
            }
        }

        private static double LengthToPoints(double value, Word.WdMeasurementUnits unit, double dpi)
        {
            switch (unit)
            {
                case Word.WdMeasurementUnits.wdCentimeters:
                    return value * dpi / 2.54;
                case Word.WdMeasurementUnits.wdMillimeters:
                    return value * dpi / 25.4;
                case Word.WdMeasurementUnits.wdInches:
                    return value * dpi;
                case Word.WdMeasurementUnits.wdPoints:
                    return value;
                case Word.WdMeasurementUnits.wdPicas:
                    return value * dpi / 72;
                default:
                    throw new InvalidEnumArgumentException(
                        nameof(unit),
                        (int)unit,
                        typeof(Word.WdMeasurementUnits)
                    );
            }
        }

        private static double PointsToLength(double value, Word.WdMeasurementUnits unit, double dpi)
        {
            switch (unit)
            {
                case Word.WdMeasurementUnits.wdCentimeters:
                    return value * 2.54 / dpi;
                case Word.WdMeasurementUnits.wdMillimeters:
                    return value * 25.4 / dpi;
                case Word.WdMeasurementUnits.wdInches:
                    return value / dpi;
                case Word.WdMeasurementUnits.wdPoints:
                    return value;
                case Word.WdMeasurementUnits.wdPicas:
                    return value * 72 / dpi;
                default:
                    throw new InvalidEnumArgumentException(
                        nameof(unit),
                        (int)unit,
                        typeof(Word.WdMeasurementUnits)
                    );
            }
        }

        public static double HeightToPoints(
            double value,
            Word.WdMeasurementUnits unit = Word.WdMeasurementUnits.wdCentimeters
        ) => LengthToPoints(value, unit, dpiY);

        public static double WidthToPoints(
            double value,
            Word.WdMeasurementUnits unit = Word.WdMeasurementUnits.wdCentimeters
        ) => LengthToPoints(value, unit, dpiX);

        public static double PointsToHeight(
            double value,
            Word.WdMeasurementUnits unit = Word.WdMeasurementUnits.wdCentimeters
        ) => PointsToLength(value, unit, dpiY);

        public static double PointsToWidth(
            double value,
            Word.WdMeasurementUnits unit = Word.WdMeasurementUnits.wdCentimeters
        ) => PointsToLength(value, unit, dpiX);
    }
}
