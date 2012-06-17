﻿using System;
using Windows.UI.Xaml.Data;

namespace AgFx.Converters {

    /// <summary>
    /// Take a boolean input and inverts its value.
    /// </summary>
    public class NotConverter : IValueConverter {

        /// <summary>
        /// Inverts the value of value to it's opposite, for booleans.
        /// </summary>
        /// <param name="value">Must be a bool.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="language"></param>
        /// <returns>The opposite of (bool)value.</returns>
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value is bool) {
                return !(bool)value;
            }
            return value;
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
