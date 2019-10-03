using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;

namespace NumberToWords.Tests {

    [TestClass]
    public class NumberToWordsTest {

        NumConverter converter;

        [TestInitialize]
        public void Startup () {
            converter = new NumConverter ();

        }

        [TestCleanup]
        public void TestClean () {
            converter = null;
        }

        [TestMethod]
        public void CheckInput_CheckForNonNumericInputs_True () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (true, converter.CheckInput ("2"));
        }

        [TestMethod]
        public void CheckInput_CheckForNonNumericInputs_False () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (false, converter.CheckInput ("a"));
        }

        [TestMethod]
        public void Converter_ConvertsNumbersOneThroughNine_StringEight () {
            Assert.AreEqual ("eight", converter.Converter ("8"));
        }

        [TestMethod]
        public void Converter_ConvertsNumbersOneThroughNineteen_StringEighteen () {
            Assert.AreEqual ("eighteen", converter.Converter ("18"));
        }

        [TestMethod]
        public void Converter_ConvertsNumbersModTen_StringTens () {
            Assert.AreEqual ("twenty five", converter.Converter ("25"));
        }

        [TestMethod]
        public void Converter_ConvertsNumbersModTen_StringHundreds () {
            Assert.AreEqual ("one hundred one", converter.Converter ("101"));
        }

        [TestMethod]
        public void Converter_ConvertsNumbersModTen_StringHundredsAndTens () {
            Assert.AreEqual ("one hundred twenty one", converter.Converter ("121"));
        }

    }
}