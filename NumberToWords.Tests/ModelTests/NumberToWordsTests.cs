using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;

namespace NumberToWords.Tests {

    [TestClass]
    public class NumberToWordsTest {

        Converter converter;

        [TestInitialize]
        public void Startup () {
            converter = new Converter ();

        }

        [TestCleanup]
        public void TestClean () {
            converter = null;
        }

        [TestMethod]
        public void CheckInput_CheckForNonAlphabeticInputs_True () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (true, converter.CheckInput ("a"));
        }
    }
}