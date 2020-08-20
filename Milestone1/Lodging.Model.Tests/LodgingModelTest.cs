using Lodging.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Lodging.Models.Tests
{
    public class LodgingModelTest
    {
        public static readonly IEnumerable<Object[]> _lodgings = new List<Object[]>
        {
          new object[]
          {
            new LodgingModel()
            {
              Id = 0,
              Location = new LocationModel(),
              Name = "name",
              Bathrooms = 5,
              Rentals = new List<RentalModel>(),
              Reviews = new List<ReviewModel>()
            }
          }
        };
        public static readonly IEnumerable<Object[]> _invalidLodgings = new List<Object[]>
        {
          new object[]
          {
            new LodgingModel()
            {
              Id = 0,
              Location = new LocationModel(),
              Name = "name",
              Bathrooms = 5,
              Rentals = new List<RentalModel>(),
              Reviews = new List<ReviewModel>()
            }
          }
        };

        [Theory]
        [MemberData(nameof(_lodgings))]
        public void Test_Create_LodgingModel(LodgingModel lodging)
        {
            var validationContext = new ValidationContext(lodging);
            var actual = Validator.TryValidateObject(lodging, validationContext, null, true);

            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(_lodgings))]
        public void Test_Validate_LodgingModel(LodgingModel lodging)
        {
            var validationContext = new ValidationContext(lodging);

            Assert.Empty(lodging.Validate(validationContext));
        }

        [Theory]
        [MemberData(nameof(_invalidLodgings))]
        public void Test_Validate_InvalidLodgingModel(LodgingModel lodging)
        {
            var validationContext = new ValidationContext(lodging);

            Assert.NotEmpty(lodging.Validate(validationContext));
        }
    }
}