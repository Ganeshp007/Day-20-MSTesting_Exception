using Day_20_MsTesting_Exceptiions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyze_Testing
{
    [TestClass]
    public class UnitTest1
    {
        private MoodAnalyzer moodAnalyzer;

        [TestMethod]
        public void GivenSadMood_shouldReturn_SAD() //Test method
        {
            // >> Arrange
            string expected = "HAPPY";
            string message = "I am in HAppy Mood";
            moodAnalyzer = new MoodAnalyzer(message);

            // >> Act
            string Result = moodAnalyzer.AnalyzeMood();

            // >> Assert
            Assert.AreEqual(expected, Result);

        }

    }
}