using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExtraBlanks;

namespace RemoveExtraBlanksTest
{
    [TestClass]
    public class InputFilesTests
    {
    	[TestMethod]
        public void CheckTooManyArguments()
        {
            string[] args = new string[] { "input.txt", "output.txt", "name.txt" };
            bool res = Program.CheckArguments(args);
            Assert.AreEqual(false, res);
        }
    	
        [TestMethod]
        public void CheckTooFewArguments()
        {
            string[] args = new string[] { "input.txt" };
            bool res = Program.CheckArguments(args);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void CorrectArgumentNumber()
        {
            string[] args = new string[] { "input.txt", "output.txt" };
            bool res = Program.CheckArguments(args);
            Assert.AreEqual(true, res);
        }
    }

    [TestClass]
    public class RemoveExtraBlanksTests
    {
        [TestMethod]
        public void RemoveTabsAtEdges()
        {
            string line = "\hello\t";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello", line);  
        }

        [TestMethod]
        public void RemoveSpacesAtEdges()
        {
            string line = "  hello   ";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello", line);
        }
        
       public void RemoveSpacesAndTabsAtEdges()
        {
            string line = "     hello\t";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello", line);  
        }

        [TestMethod]
        public void RemoveSpacesBetweenWords()
        {
            string line = "hello      world";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello world", line);
        }
        
        [TestMethod]
        public void RemoveTabsBetweenWords()
        {
            string line = "hello\t\t\tworld";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello\tworld", line);
        }

        [TestMethod]
        public void RemoveSpacesAndTabs()
        {
            string line = "  hello\t     my\t\t world  ";
            line = Program.RemoveExtraBlanks(line);
            Assert.AreEqual("hello my world", line);
        }

    }
}
