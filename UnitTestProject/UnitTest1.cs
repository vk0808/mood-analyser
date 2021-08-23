using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenGivenMoodSad_ShouldReturnSad()
        {
            // Arrange
            MoodAnalyser mood = new MoodAnalyser("sad");

            // Act
            string result = mood.AnalyseMood();

            // Assert
            Assert.AreEqual("SAD", result);
        }
    }
}
