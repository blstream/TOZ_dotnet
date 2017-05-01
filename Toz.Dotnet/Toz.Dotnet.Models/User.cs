using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Toz.Dotnet.Models.CustomValidationAttributes;
using Toz.Dotnet.Models.EnumTypes;

namespace Toz.Dotnet.Models
{
    public class User : UserBase
    {
        [Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        [JsonProperty("phoneNumber")]        
        [PhoneNumber(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "InvaildPhoneNumber")]
        public string PhoneNumber {get; set;}
        
		[Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        [JsonProperty("email")]
		[EmailAddress(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmailValidationMessage")]
        public string Email {get; set;}
        
		[Required(ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "EmptyField")]
        [JsonProperty("purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Range(0,2, ErrorMessageResourceType = typeof(Resources.ModelsDataValidation), ErrorMessageResourceName = "TypeUndefined")]
        public UserType Purpose {get; set;}

    }
}
