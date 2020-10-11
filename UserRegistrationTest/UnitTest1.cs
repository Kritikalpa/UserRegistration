using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private User user;

        public UnitTest1()
        {
            user = new User();
        }

        [TestMethod]
        [DataRow("Kriti Kalpa", true)]
        [DataRow("Blue18", false)]
        public void firstNameValidation(string firstName, bool expected)
        {
            bool result = user.validateFirstName(firstName);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("Saha", true)]
        [DataRow("S", false)]
        public void lastNameValidation(string lastName, bool expected)
        {
            bool result = user.validateLastName(lastName);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("krtklpsh@gmail.co.in", true)]
        [DataRow("kriti..@capgemini.com", false)]
        public void emailIdValidation(string emailId, bool expected)
        {
            bool result = user.validateEmailId(emailId);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("91 8794761714", true)]
        [DataRow("8794761714", false)]
        public void phoneNumberValidation(string phoneNumber, bool expected)
        {
            bool result = user.validatePhoneNumber(phoneNumber);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow("Qwerty@123", true)]
        [DataRow("qwerty123", false)]
        public void passwordValidation(string password, bool expected)
        {
            bool result = user.validatePassword(password);
            Assert.AreEqual(result, expected);
        }
    }
}
