using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace friendcognitionTests
{
    [TestClass]
    public class DataControllerTests
    {
        [TestMethod]
        public void ValidateEmail_CorrectEmailFormat_IsTrue()
        {
            string correctEmail = "surname@gmail.com";

            bool result = DataController.Instance().ValidateEmail(correctEmail);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateEmail_WithoutEta_IsFalse()
        {
            string notCorrectEmail = "surnamegmail.com";

            bool result = DataController.Instance().ValidateEmail(notCorrectEmail);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateEmail_WithoutDot_IsFalse()
        {
            string notCorrectEmail = "surname@gmailcom";

            bool result = DataController.Instance().ValidateEmail(notCorrectEmail);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateStringOnlyLetters_CorrectInput_IsTrue()
        {
            string correctInput = "asdSDSAIniscsiu";

            bool result = DataController.Instance().ValidateStringOnlyLetters(correctInput);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateStringOnlyLetters_InputAsNumbers_IsFalse()
        {
            string notCorrectInput = "31235342";

            bool result = DataController.Instance().ValidateStringOnlyLetters(notCorrectInput);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateStringOnlyLetters_InputAsRandomSigns_IsFalse()
        {
            string notCorrectInput = "/,.;[];";

            bool result = DataController.Instance().ValidateStringOnlyLetters(notCorrectInput);

            Assert.IsFalse(result);
        }
    }
}
