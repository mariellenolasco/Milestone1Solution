using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lodging.Models
{
    /// <summary>
    /// Review model that represents the details of a review
    /// </summary>
    public class ReviewModel : IValidatableObject
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public string Comment { get; set; }

        public DateTime DateCreated { get; set; }

        public int Rating { get; set; }

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