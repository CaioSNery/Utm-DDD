using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        public Campaign(string name, string source, string medium, string? id = null, string? term = null, string? content = null)
        {
            Name = name;
            Source = source;
            Medium = medium;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaignException.ThrowIfNull(source, "Source is invalid");
            InvalidCampaignException.ThrowIfNull(medium, "Medium is invalid");
            InvalidCampaignException.ThrowIfNull(name, "Name is invalid");

        }


        public string Name { get; }
        public string Source { get; }
        public string Medium { get; }
        public string? Id { get; }
        public string? Term { get; set; }
        public string? Content { get; }


    }
}