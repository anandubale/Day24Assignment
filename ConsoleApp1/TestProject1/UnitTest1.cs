using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;


namespace TestProject1
{

    [TestClass]
    public class UnitTest1
    {   //Arrange
        //Act
        //Assert
        [TestMethod]
        public void GivenFirstName_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns name = new RegexPatterns();
            bool result = name.ValidateName("Anand", RegexPatterns.FIRSTNAME_REGEX);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns lastname = new RegexPatterns();
            bool resultlastname = lastname.ValidateLastName("Ubale", RegexPatterns.LASTNAME_REGEX);
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void GivenPhoneNum_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns phonenum = new RegexPatterns();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890", RegexPatterns.PHONENUM_REGEX);
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void GivenEmailId_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns emailid = new RegexPatterns();
            bool resultemailid = emailid.ValidateEmail("Anandubale11@gmail.com", RegexPatterns.EMAIL_REGEX);
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TGivenPassword_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns pass = new RegexPatterns();
            bool resultpass = pass.ValidatePassword("123A@dsd659", RegexPatterns.PASSWORD_REGEX);
            Assert.IsTrue(resultpass);
        }
    }
}
