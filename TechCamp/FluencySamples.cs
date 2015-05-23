using Fluency;
using Fluency.DataGeneration;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace TechCamp
{
   [TestFixture]
   class FluencySamples
   {
      [Test]
      public void TestUserNameValidation()
      {
         //Arrange
         var input = new UserInfo { Name = "" };
         var testedObject = new UserValidator();
         var expected = false;

         //Act
         var actual = testedObject.Validate(input);

         //Assert
         actual.ShouldBeEquivalentTo(expected);
      }

      class a
      {
         public static UserInfoBuilder UserInfo
         {
            get { return new UserInfoBuilder(); }
         }

         public class UserInfoBuilder : FluentBuilder<UserInfo>
         {
            public UserInfoBuilder()
            {
               SetProperty(x => x.Name, ARandom.FirstName());
               SetProperty(x => x.LastName, ARandom.LastName());
               SetProperty(x => x.EmailAddress, ARandom.Email());
               SetProperty(x => x.BirthDate, ARandom.BirthDate());
               SetProperty(x => x.PhoneNumber, ARandom.StringPattern("### ### ###"));
               SetProperty(x => x.Height, ARandom.IntBetween(140, 190));
            }

            public UserInfoBuilder WithoutName()
            {
               SetProperty(x => x.Name, string.Empty);
               return this;
            }

            public UserInfoBuilder WithInvalidEmailAddress()
            {
               SetProperty(x => x.EmailAddress, ARandom.InternetHostName());
               return this;
            }
         }
      }

      [Test]
      public void TestUserNameValidation_()
      {
         //Arrange
         var input = new UserInfo
         {
            Name = "",
            LastName = "Bbb",
            BirthDate = new DateTime(1999, 01, 01),
            EmailAddress = "name.lastname@example.com",
            Height = 180,
            PhoneNumber = "555-55-55"
         };

         var testedObject = new UserValidator();
         var expected = false;

         //Act
         var actual = testedObject.Validate(input);

         //Assert
         actual.ShouldBeEquivalentTo(expected);
      }

      [Test]
      public void TestUserNameValidation__()
      {
         //Arrange
         var input = a.UserInfo.WithoutName().build();

         var testedObject = new UserValidator();
         var expected = false;

         //Act
         var actual = testedObject.Validate(input);

         //Assert
         actual.ShouldBeEquivalentTo(expected);
      }



      private class UserValidator
      {
         public bool Validate(UserInfo input)
         {
            throw new NotImplementedException();
         }
      }
   }
}
