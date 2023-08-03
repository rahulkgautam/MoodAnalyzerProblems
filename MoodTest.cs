using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodTestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestHappyMood()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();
            string message = "I am feeling Happy today!";
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("Happy", mood);
        }

        [TestMethod]
        public void TestSadMood()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();
            string message = "I am feeling sad today!";
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("Sad", mood);
        }
    }
}
