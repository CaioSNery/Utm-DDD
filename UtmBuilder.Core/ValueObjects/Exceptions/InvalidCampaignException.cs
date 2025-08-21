using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMEssage = "Invalid UTM Parameters";

        public InvalidCampaignException(string message = DefaultErrorMEssage) : base(message) { }


        public static void ThrowIfNull(string? item, string message = DefaultErrorMEssage)
        {
            if (string.IsNullOrEmpty(item))
                throw new InvalidCampaignException(message);

            if (!UrlRegex().IsMatch(item))
                throw new InvalidCampaignException();
        }

        [GeneratedRegex(@"^(http|https):\/\/[a-z0-9]+(\.[a-z]{2,})*(\/[a-z0-9\-\._~:\/?#\[\]@!$&'()*+,;=%]*)?$")]
        private static partial Regex UrlRegex();
    }
}