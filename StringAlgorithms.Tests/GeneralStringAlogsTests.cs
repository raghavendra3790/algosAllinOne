using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAlgorithms.Tests
{
    [TestClass]
    public class GeneralStringAlogsTests
    {
        [TestMethod]
        public void TestIsAnagram()
        {
            Assert.IsTrue(GeneralStringAlgos.isAnagram("hello", "hello"));
        }

        [TestMethod]
        public void TestIsAnagramFalse()
        {
            Assert.IsFalse(GeneralStringAlgos.isAnagram("alpha", "alphs"));
        }

        [TestMethod]
        public void TestIsPalindrome()
        {
            Assert.IsTrue(GeneralStringAlgos.isPalindrome("madam"));
            Assert.IsFalse(GeneralStringAlgos.isPalindrome("general"));
        }
    }
}
