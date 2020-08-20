using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lodging.Models
{
    /// <summary>
    /// Model for the rentals found in a lodging and its rental units
    /// </summary>
    public class RentalModel : IValidatableObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Total number of occupants
        /// </summary>
        public int Occupancy { get; set; }

        /// <summary>
        /// type of site
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// booking status, one of:
        ///    - available(neither booked nor currently in use)
        ///    - booked(booked by someone else, but not in use)
        ///    - occupied(currently in use)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Nightly cost
        /// </summary>
        public double Price { get; set; }
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