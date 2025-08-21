using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException : Exception
    {
        private const string DefaultErrorMEssage = "Invalid Url";

        public InvalidUrlException(string message = DefaultErrorMEssage) : base(message) { }


        public static void ThrowIfInvalid(string address, string message = DefaultErrorMEssage)
        {
            if (string.IsNullOrEmpty(address))
                throw new InvalidUrlException(message);

            if (!UrlRegex().IsMatch(address))
                throw new InvalidUrlException();
        }

        [GeneratedRegex(@"^(http|https):\/\/[a-z0-9]+(\.[a-z]{2,})*(\/[a-z0-9\-\._~:\/?#\[\]@!$&'()*+,;=%]*)?$")]
        private static partial Regex UrlRegex();

    }
}