﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using CSHUE.Cultures;

namespace CSHUE.Helpers
{
    public static class Converters
    {
        public static CultureInfo GetCultureInfoFromIndex(int index)
        {
            return CultureResources.SupportedCultures.ElementAt(index);
        }

        public static int GetIndexFromCultureInfo(CultureInfo cultureInfo)
        {
            return CultureResources.SupportedCultures.IndexOf(cultureInfo);
        }
    }

    public class BoolToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && (bool)value ? 1 : 0.5;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class ByteToPercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null) return (int)Math.Round(double.Parse(value.ToString()) / 255 * 100);
            return 0;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null) return (byte)Math.Round(double.Parse(value.ToString()) / 100 * 255);
            return 0;
        }
    }

    public class VisibleToCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && (Visibility) value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && (Visibility)value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }
    }

    public class FalseToTrueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && !(bool)value;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && !(bool)value;
        }
    }

    public class EmptyStringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }
    }

    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null && (bool)value)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && (Visibility)value == Visibility.Visible;
        }
    }

    public class BoolToCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null && (bool)value)
            {
                return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value != null && (Visibility)value == Visibility.Collapsed;
        }
    }

    public class BrightnessToWhiteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null)
                return Color.FromRgb((byte)Math.Round((double)value * 255),
                    (byte)Math.Round((double)value * 255),
                    (byte)Math.Round((double)value * 255));

            return Colors.Black;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return Colors.Black;
        }
    }

    public class BrightnessToPercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null) return (int)Math.Round((double)value * 100);
            return 0;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null) return (double)value / 100;
            return 0;
        }
    }
}
