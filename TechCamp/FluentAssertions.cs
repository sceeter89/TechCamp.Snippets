using FluentAssertions;
using FluentAssertions.Types;
using NUnit.Framework;
using System;

namespace TechCamp
{
   public class UserInfo
   {
      public DateTime BirthDate { get; set; }
      public string Name { get; set; }
      public string LastName { get; set; }
      public string PhoneNumber { get; set; }
      public string EmailAddress { get; set; }
      public int Height { get; set; }

      public void SetNameAndLastName() { }
   }

   [TestFixture]
   class FluentAssertions
   {
      [Test]
      public void TestIfNameAndLastNameAreSetProperly()
      {
         //Arrange
         var testedObject = new UserInfo();

         //Act
         testedObject.SetNameAndLastName();

         //Assert
         Assert.That(testedObject.Name, Is.EqualTo("Somename"));
         Assert.That(testedObject.LastName, Is.EqualTo("Somelastname"));
      }

      [Test]
      public void _TestIfNameAndLastNameAreSetProperly()
      {
         //Arrange
         var testedObject = new UserInfo();

         //Act
         testedObject.SetNameAndLastName();

         //Assert
         testedObject.Name.ShouldBeEquivalentTo("Somename");
         testedObject.LastName.ShouldBeEquivalentTo("Somelastname");
      }

      [Test]
      public void __TestIfNameAndLastNameAreSetProperly()
      {
         //Arrange
         var testedObject = new UserInfo();
         var expected = new { Name = "Somename", LastName = "Somelastname" };

         //Act
         testedObject.SetNameAndLastName();

         //Assert
         testedObject.ShouldBeEquivalentTo(expected,
            opt => opt.ExcludingMissingMembers());
      }

      class MyClass { }
      class MyController { }
      class AuthorizeAttribute : Attribute { }

      [Test]
      public void AllControllersShouldBeMarkedWithAuthorizeAttribute()
      {
         var myAssembly = typeof(MyClass).Assembly;

         AllTypes.From(myAssembly)
            .ThatDeriveFrom<MyController>()
            .Should().BeDecoratedWith<AuthorizeAttribute>();
      }
   }
}
