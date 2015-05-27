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
      public int Height { get; set; } = 180; // C# 6

      public void SetNameAndLastName() { }
   }

   [TestFixture]
   class FluentAssertions
   {
      class MyDisposable : IDisposable { public void Dispose() { } }

      [Test]
      public void TestIfNameAndLastNameAreSetProperly()
      {


         using (var myDisposable = new MyDisposable())
         {
            // Do stuff with myDisposable
         }
         var lockObject = new object();
         lock (lockObject)
         {
            // Synchronized block
         }

         //Arrange
         var testedObject = new UserInfo();

         //Act
         testedObject.SetNameAndLastName();

         //Assert
         Assert.That(testedObject.Name, Is.EqualTo("Somename"));
         Assert.That(testedObject.LastName, Is.EqualTo("Somelastname"));
      }

      [Test]
      public void ___TestIfNameAndLastNameAreSetProperly()
      {
         //Arrange
         var testedObject = new UserInfo();

         //Act
         testedObject.SetNameAndLastName();

         //Assert
         Assert.AreEqual(testedObject.Name, "Somename");
         Assert.AreEqual(testedObject.LastName, "Somelastname");
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
         var expected = new
         {
            Name = "Somename",
            LastName = "Somelastname",
            BirthDate = 10.March(1995)
         };

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
