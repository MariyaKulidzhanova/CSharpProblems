using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTasks;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BracketsTest1()
        {
            //Arrange
            bool expected = false;

            //Act
            Brackets bracketsLine = new Brackets("(()(");
            bool actual = bracketsLine.CountBrackets();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void BracketsTest2()
        {
            //Arrange
            bool expected = true;

            //Act
            Brackets bracketsLine = new Brackets("(())()");
            bool actual = bracketsLine.CountBrackets();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void RomanNumbersTest1()
        {
            //Arrange
            int expected = 19;

            //Act
            RomanNumbers romanNumbers = new RomanNumbers("xix");
            int actual = romanNumbers.RomanToInt();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void RomanNumbersTest2()
        {
            //Arrange
            int expected = 101;

            //Act
            RomanNumbers romanNumbers = new RomanNumbers("CI");
            int actual = romanNumbers.RomanToInt();

            //Assert
            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void DoubleLinkedListTest1()
        {
            //Arrange
            int a = 16;

            //Act
            DoubleLinkedList<int> actual = new DoubleLinkedList<int>();
            actual.AddFirst(-9);
            actual.AddLast(5);
            actual.AddLast(16);
            actual.Reverse();

            //Assert
            Assert.AreEqual(a, actual.First.Value, "Method is incorrect");
        }

        [TestMethod]
        public void DoubleLinkedListTest2()
        {
            //Arrange
            int a = -9;

            //Act
            DoubleLinkedList<int> actual = new DoubleLinkedList<int>();
            actual.AddFirst(-9);
            actual.AddLast(5);
            actual.AddLast(16);
            actual.Reverse();

            //Assert
            Assert.AreEqual(a, actual.Last.Value, "Method is incorrect");
        }
    }
}
