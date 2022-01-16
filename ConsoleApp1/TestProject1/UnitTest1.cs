using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        //Act
        //Assert
        [TestMethod]
        //Arrange
        //Act
        //Assert
      
        public void TestFirstNameReturnsTrue()
        {
            RegexPatterns firstname = new RegexPatterns();
            bool result = firstname.ValidateName("Anand");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastNameReturnsTrue()
        {
            RegexPatterns lastname = new RegexPatterns();
            bool resultlastname = lastname.ValidateLastName("Ubale");
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void TestPhoneNumberReturnsTrue()
        {
            RegexPatterns phonenum = new RegexPatterns();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890");
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void TestEmailIdReturnsTrue()
        {
            RegexPatterns emailid = new RegexPatterns();
            bool resultemailid = emailid.ValidateEmail("Anandubale11@gmail.com");
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TestPasswordReturnsTrue()
        {
            RegexPatterns pass = new RegexPatterns();
            bool resultpass = pass.ValidatePassword("46a4s5@Aknac");
            Assert.IsTrue(resultpass);
        }
    }
}
