using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lodging.Models
{
    /// <summary>
    /// This represents the address model of the api
    /// </summary>
    public class AddressModel : IValidatableObject
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string StateProvince { get; set; }

        public string Street { get; set; }

        /// <summary>
        /// This is the object's validate method, returns all validation errors in a list that the end user can go through
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) 
        {
            IEnumerable<ValidationResult> validationResults = new List<ValidationResult>();
            var isPostalCodeValid = validatePostalCode(this.PostalCode);
            if ( isPostalCodeValid != null) validationResults = validationResults.Append(isPostalCodeValid);
            return validationResults;
        }

        //Checks if the postal code is valid
        public ValidationResult validatePostalCode(string postalCode)
        {
            if (postalCode.Length != 5) return new ValidationResult("Postal Code should be exactly five digits");
            if (Regex.IsMatch(postalCode, "[^0-9]+")) return new ValidationResult("Postal Code should be composed of digits only");
            return null;
        }
    }
}
