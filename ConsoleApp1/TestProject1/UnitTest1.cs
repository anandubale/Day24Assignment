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
            RegexPatterns firstname = new RegexPatterns();
            bool result = firstname.ValidateName("Anand");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns lastname = new RegexPatterns();
            bool resultlastname = lastname.ValidateLastName("Ubale");
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void GivenPhoneNum_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns phonenum = new RegexPatterns();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890");
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void GivenEmailId_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns emailid = new RegexPatterns();
            bool resultemailid = emailid.ValidateEmail("ANANDUBALE11@gmail.com");
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TGivenPassword_WhenCheck_ShouldReturnTrue()
        {
            RegexPatterns pass = new RegexPatterns();
            bool resultpass = pass.ValidatePassword("46a4s5@Aknac");
            Assert.IsTrue(resultpass);
        }
    }
}
