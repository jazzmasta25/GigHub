using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), new []{"MM/dd/yyyy","M/d/yyyy","MM/d/yyyy","M/dd/yyyy"}, CultureInfo.CurrentCulture,
                DateTimeStyles.None, out dateTime);

            return (isValid && dateTime > DateTime.Now);

        }
    }
}