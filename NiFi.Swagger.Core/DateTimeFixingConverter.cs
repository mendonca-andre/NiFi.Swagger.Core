// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateTimeFixingConverter.cs" company="">
//   
// </copyright>
// <summary>
//   The bad date fixing converter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NiFi.Swagger.Core
{
    using System;
    using System.Globalization;

    using Newtonsoft.Json;

    /// <summary>
    /// The bad date fixing converter.
    /// </summary>
    public class DateTimeFixingConverter : JsonConverter
    {
        /// <summary>
        /// The can convert.
        /// </summary>
        /// <param name="objectType">   
        /// The object type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }

        /// <summary>
        /// The write json.
        /// </summary>
        /// <param name="writer">
        /// The writer.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// The not Implemented Exception
        /// </exception>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The read json.
        /// </summary>
        /// <param name="reader">
        /// The reader.
        /// </param>
        /// <param name="objectType">
        /// The object type.
        /// </param>
        /// <param name="existingValue">
        /// The existing value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var rawDate = (string)reader.Value;
            if (DateTime.TryParse(rawDate, out var date))
            {
                return date;
            }

            var localEnUs = new CultureInfo("en-US");
            var formatStrings = new[]
                                    {
                                        "MM/dd/yyyy hh:mm:ss tt", "yyyy-MM-dd hh:mm:ss", "MM/dd/yyyy HH:mm:ss EDT",
                                        "M/d/yyyy h:mm tt PST", "M/d/yyyy h:mm tt PST", "M/d/yyyy h:mm tt PDT",
                                        "M/d/yyyy h:mm tt MST", "M/d/yyyy h:mm tt MDT", "M/d/yyyy h:mm tt CST",
                                        "M/d/yyyy h:mm tt CDT", "M/d/yyyy h:mm tt EST", "M/d/yyyy h:mm tt EDT"
                                    };

            if (DateTime.TryParseExact(rawDate, formatStrings, localEnUs, DateTimeStyles.None, out date))
            {
                return date;
            }

            // It's not a date after all, so just return the default value
            if (objectType == typeof(DateTime?))
            {
                return null;
            }

            return DateTime.MinValue;
        }
    }
}
