﻿// Copyright 2013-2019 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using System.Diagnostics.CodeAnalysis;

namespace ImageMagick
{
    /// <summary>
    /// An array value of the exif profile.
    /// </summary>
    /// <typeparam name="TValueType">The type of the value.</typeparam>
    public abstract class ExifArrayValue<TValueType> : ExifValue
    {
        internal ExifArrayValue(ExifTag<TValueType[]> tag)
            : base(tag)
        {
        }

        internal ExifArrayValue(ExifTagValue tag)
            : base(tag)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the value is an array.
        /// </summary>
        public override bool IsArray => true;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [SuppressMessage("Naming", "CA1721:Property names should not match get methods", Justification = "This value is typed.")]
        [SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "The property needs to be an array.")]
        public TValueType[] Value { get; set; }

        /// <summary>
        /// Gets the value of this exif value.
        /// </summary>
        /// <returns>The value of this exif value.</returns>
        public override object GetValue() => Value;

        /// <summary>
        /// Tries to set the value and returns a value indicating whether the value could be set.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A value indicating whether the value could be set.</returns>
        public override bool SetValue(object value)
        {
            if (value == null)
            {
                Value = null;
                return true;
            }

            if (value is TValueType[] typeValue)
            {
                Value = typeValue;
                return true;
            }

            return false;
        }
    }
}