using System;
using NUnit.Framework;
using CommonModels;
using RequestBuilderSwitch;

namespace RequestBuilderSwitchTests
{
    [TestFixture]
    public class RequestBuilderTests
    {
        [Test]
        public void Null_User_Throws_ArgumentNullException()
        {
            //Assign
            User newUser = null;

            //Act Assert
            Assert.That(()=> RequestBuilder.CreateUser(newUser), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Not_Null_User_Does_Not_Throw_ArgumentNullException()
        {
            //Assign
            var newUser = new User();

            //Act
            var user = RequestBuilder.CreateUser(newUser);

            //Assert
            Assert.That(user, Is.Not.Null);
        }

        [Test]
        public void SomeTest()
        {
            //Assign
            var newUser = new User();
            var firstName = "Aaron";
            var lastName = "Job";

            newUser.FirstName = firstName;
            newUser.LastName = lastName;

            //Act
            var user = RequestBuilder.CreateUser(newUser);

            //Assert
            Assert.That(user.Id, Is.Not.EqualTo(0));
            Assert.That(user.FirstName, Is.Not.EqualTo(firstName));
            Assert.That(user.LastName, Is.Not.EqualTo(lastName));
        }
    }
}
