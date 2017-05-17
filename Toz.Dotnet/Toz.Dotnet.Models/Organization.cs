﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Toz.Dotnet.Models.OrganizationSubtypes;

namespace Toz.Dotnet.Models
{
    public class Organization
    {
        [JsonProperty("name")]
        [RegularExpression(@"(([^\u0000-\u007F]|[a-zA-Z])+[\.\-\']?([^\u0000-\u007F]|[a-zA-Z]|(\s(?!$))+)?[\.]?)*", ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "InvalidField")]
        [Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        public string Name { get; set; }
                
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("bankAccount")]
        public BankAccount BankAccount { get; set; }
    }
}
