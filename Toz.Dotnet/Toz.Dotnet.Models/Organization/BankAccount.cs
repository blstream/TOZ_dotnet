﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Toz.Dotnet.Models.Validation;

namespace Toz.Dotnet.Models.Organization
{
    public class BankAccount
    {
        [JsonProperty("number")]
        [Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        [BankAccountNumber(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "InvalidBankAccount")]
        public string Number { get; set; }

        [JsonProperty("bankName")]
        [Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        [RegularExpression(@"(([^\u0000-\u007F]|[a-zA-Z])+[\.\-\']?([^\u0000-\u007F]|[a-zA-Z]|(\s(?!$))+)?[\.]?)*", ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "InvalidValue")]
        public string BankName { get; set; }
    }
}