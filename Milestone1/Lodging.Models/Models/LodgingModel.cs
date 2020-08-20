using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lodging.Models.Models
{
    /// <summary>
    /// Model for the Lodging and all its details
    /// </summary>
    public class LodgingModel : IValidatableObject
    {
        public int Id { get; set; }

        public LocationModel Location { get; set; }

        public string Name { get; set; }

        public int Bathrooms { get; set; }
        public IEnumerable<RentalModel> Rentals { get; set; }

        public IEnumerable<ReviewModel> Reviews { get; set; }

        /// <summary>
        /// This is the object's validate method, returns all validation errors in a list that the end user can go through
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}