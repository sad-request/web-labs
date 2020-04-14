using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;

namespace PasswordStrengthTests
{
    [TestClass]
    public class CalculateSecurityByLenghtTest
    {
        [TestMethod]
        public void PasswordStrengthIs4()
        {
            string password = "a";
            int requiredStrength = 4;
            int res = Program.CalculateSecurityByLenght(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void PasswordStrengthIs20()
        {
            string password = "cat12";
            int requiredStrength = 20;
            int res = Program.CalculateSecurityByLenght(password);
            Assert.AreEqual(requiredStrength, res);
        }
    }

    [TestClass]
    public class CalculateSecurityByOnlyDigitsTest
    {
        [TestMethod]
        public void OnlyDigitTest()
        {
            string password = "12345";
            int requiredStrength = 20;
            int res = Program.CalculateSecurityByOnlyDigits(password);
            Assert.AreEqual(requiredStrength, res);
        }


        [TestMethod]
        public void DigitsAndLettersMustIgnorLetters()
        {
            string password = "letter12";
            int requiredStrength = 8;ы
            int res = Program.CalculateSecurityByOnlyDigits(password);
            Assert.AreEqual(requiredStrength, res);
        }
    }

    [TestClass]
    public class CalculateSecurityByUpperCaseLettersTotalTest
    {
        [TestMethod]
        public void OnlyUpperCaseIs0()
        {
            string password = "ONLYUPPER";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByUpperCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void UpperAndLower10()
        {
            string password = "UPPERlower";
            int requiredStrength = 10;
            int res = Program.CalculateSecurityByUpperCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void OnlyLowerIs0()
        {
            string password = "hello123";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByUpperCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }
    }

    [TestClass]
    public class CalculateSecurityByLowerCaseLettersTotalTest
    {
        [TestMethod]
        public void OnlyUpperCaseIs0()
        {
            string password = "ONLYUPPER";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByLowerCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void UpperAndLower10()
        {
            string password = "UPPERlower";
            int requiredStrength = 10;
            int res = Program.CalculateSecurityByLowerCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void OnlyLowerIs0()
        {
            string password = "onlylower";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByLowerCaseLettersTotal(password);
            Assert.AreEqual(requiredStrength, res);
        }
    }

    [TestClass]
    public class CalculateSecurityByOnlyLettersTest
    {
        [TestMethod]
        public void DigitsAndLetters()
        {
            string password = "word123";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByOnlyLetters(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void OnlyLetters()
        {
            string password = "AAsBBsXaaa";
            int requiredStrength = -10;
            int res = Program.CalculateSecurityByOnlyLetters(password);
            Assert.AreEqual(requiredStrength, res);
        }

        }
    }

    [TestClass]
    public class CalculateSecurityByOnlyDigitsTest
    {
        [TestMethod]
        public void DigitsAndLettesTest()
        {
            string password = "word123";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByOnlyDigits(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void OnlyDigitsTest()
        {
            string password = "123456";
            int requiredStrength = -6;
            int res = Program.CalculateSecurityByOnlyDigits(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void OnlyLettersTest()
        {
            string password = "hello";
            int requiredStrength = 0;
            int res = Program.CalculateSecurityByOnlyDigits(password);
            Assert.AreEqual(requiredStrength, res);
        }
    }

    [TestClass]
    public class CalculateSecurityByReapetedSymbolsTest
    {
        [TestMethod]
        public void OnlySameSymbols()
        {
            string password = "aaa";
            int requiredStrength = -3;
            int res = Program.CalculateSecurityByReapetedSymbols(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void NotOnlySameSymbols()
        {
            string password = "helloworld";
            int requiredStrength = -4;
            int res = Program.CalculateSecurityByReapetedSymbols(password);
            Assert.AreEqual(requiredStrength, res);
        }

        [TestMethod]
        public void NoSameSymbols()
        {
            string password = "word";
            int requiredStrength = -10;
            int res = Program.CalculateSecurityByReapetedSymbols(password);
            Assert.AreEqual(requiredStrength, res);
        }
        
    }

    [TestClass]
    public class PasswordStrengthTest
    {    	
        [TestMethod]
        public void SameSymbols()
        {
            string password = "aaaa";
            int requiredStrength = 8;
            int res = Program.PasswordStrength(password);
            Assert.AreEqual(requiredStrength, res);
        }
        
        [TestMethod]
        public void OnlyDigits()
        {
            string password = "123456";
            int requiredStrength = 42;
            int res = Program.PasswordStrength(password);
            Assert.AreEqual(requiredStrength, res);
        }
        
        [TestMethod]
        public void NormalPassword()
        {
            string password = "world123";
            int requiredStrength = 54;
            int res = Program.PasswordStrength(password);
            Assert.AreEqual(requiredStrength, res);
        }

    }
}