using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckIdentifierTests
{
    
    [TestClass]
    public class IsLatinLetter
    {
        [TestMethod]
        public void DigitIsNotLatin()
        {
            char digit = '0';
            bool result = CheckIdentifier.Program.IsLatinLetter(digit);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void RussianIsNotLatin()
        {
            char letter = 'м';
            bool result = CheckIdentifier.Program.IsLatinLetter(letter);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void SpecialSymbolIsNotLatin()
        {
            char letter = '#';
            bool result = CheckIdentifier.Program.IsLatinLetter(letter);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void SpaceIsNotLatin()
        {
            char letter = ' ';
            bool result = CheckIdentifier.Program.IsLatinLetter(letter);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void LatinTrue()
        {
            char letter = 's';
            bool result = CheckIdentifier.Program.IsLatinLetter(letter);
            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class IsLatinLettersOrDigit
    {
        
        [TestMethod]
        public void SpaceIsNotLetterOrDigit()
        {
            string str = "hello world";
            bool result = CheckIdentifier.Program.IsLatinLettersOrDigit(str);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void EmptyStringIsNotIncludeLetterOrDigit()
        {
            string str = "";
            bool result = CheckIdentifier.Program.IsLatinLettersOrDigit(str);
            Assert.AreEqual(true, result);

        [TestMethod]
        public void RussianIsNotLetterOrDigit()
        {
            string str = "helloмworld";
            bool result = CheckIdentifier.Program.IsLatinLettersOrDigit(str);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void SpecialSymbolIsNotLetterOrDigit()
        {
            string str = "hello%world";
            bool result = CheckIdentifier.Program.IsLatinLettersOrDigit(str);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void IsLetterOrDigit()
        {
            string str = "hello1";
            bool result = CheckIdentifier.Program.IsLatinLettersOrDigit(str);
            Assert.AreEqual(true, result);
        }
    }

    [TestClass]
    public class TakeArgsTests
    {
    	
        [TestMethod]
        public void TooManyArgs()
        {
            string[] str = { "black", "sabbath" };
            string input = "";
            bool result = CheckIdentifier.Program.ParseArgs(str, ref input);
            Assert.AreEqual(false, result);
        }
    	
        [TestMethod]
        public void TooFewArgs()
        {
            string[] str = {};
            string input = "";
            bool result = CheckIdentifier.Program.TakeArgs(str, ref input);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void CorrectArgsNumber()
        {
            string[] str = { "black" };
            string input = "";
            bool result = CheckIdentifier.Program.ParseArgs(str, ref input);
            Assert.AreEqual(true, result);
        }
    }

    
    [TestClass]
    public class CheckIdentifierTests
    {
        [TestMethod]
        public void StartWithDigitIsWrongIdentifier()
        {
            string str = "4identifier";
            bool result = CheckIdentifier.Program.CheckIdentifier(str);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void SpecialSymbolIncludingIsWrongIdentifier()
        {
            string str = "wrong@identifier";
            bool result = CheckIdentifier.Program.CheckIdentifier(str);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void RussianIncludeWrongIdentifier()
        {
            string str = "identifierрусский";
            bool result = CheckIdentifier.Program.CheckIdentifier(str);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void EmptyStringIsWrongIdenrifier()
        {
            string str = "";
            bool result = CheckIdentifier.Program.CheckIdentifier(str);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CorrectIdentifier()
        {
            string str = "identifier9";
            bool result = CheckIdentifier.Program.CheckIdentifier(str);
            Assert.AreEqual(true, result);
        }
    }
}