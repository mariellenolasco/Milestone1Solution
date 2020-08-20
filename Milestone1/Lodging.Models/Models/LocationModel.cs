using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lodging.Models.Models
{
    /// <summary>
    /// Model for describing the location of a lodging
    /// </summary>
    public class LocationModel : IValidatableObject
    {
        public int Id { get; set; }

        public AddressModel Address { get; set; }

        public string Latitude { get; set; }

        public string Locale { get; set; }

        public string Longitude { get; set; }

        /// <summary>
        /// This is the object's validate method, returns all validation errors in a list that the end user can go through
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}