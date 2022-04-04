using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        //Subtract tests
        [Test]
        public void Subtract_Valid_Overbeek()
        {
            Assert.AreEqual(2, Program.Subtract("4", "2"));
            Assert.AreEqual(5, Program.Subtract("7", "2"));
            Assert.AreEqual(12, Program.Subtract("19", "7")); 
        }
        
        [Test]
        public void Subtract_Invalid_Overbeek()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        
        [Test]
        public void Subtract_Null_Overbeek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        //Multiply tests
        [Test]
        public void Multiply_Valid_Overbeek()
        {
            Assert.AreEqual(8, Program.Multiply("4", "2"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.AreEqual(56, Program.Multiply("8", "7")); 
        }
        
        [Test]
        public void Multiply_Invalid_Overbeek()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        
        [Test]
        public void Multiply_Null_Overbeek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        
        //Divide tests
        [Test]
        public void Divide_Valid_Overbeek()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(2, Program.Divide("20", "10"));
            Assert.AreEqual(3, Program.Divide("12", "4")); 
        }
        
        [Test]
        public void Divide_Invalid_Overbeek()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        
        [Test]
        public void Divide_Null_Overbeek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
        //Power tests
        public void Power_Valid_Overbeek()
        {
            Assert.AreEqual(16, Program.Power("4", "2"));
            Assert.AreEqual(125, Program.Power("5", "3"));
            Assert.AreEqual(32, Program.Power("2", "5")); 
        }
        
        [Test]
        public void Power_Invalid_Overbeek()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        
        [Test]
        public void Power_Null_Overbeek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
