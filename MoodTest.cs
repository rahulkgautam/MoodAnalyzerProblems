using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodTestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestHappyMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "I am feeling Happy today!";
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("Happy", mood);
        }

        [TestMethod]
        public void TestSadMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "I am feeling sad today!";
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("Sad", mood);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestNullMessage()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = null;
            string mood = moodAnalyser.AnalyseMood(message);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestEmptyMessage()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = string.Empty;
            string mood = moodAnalyser.AnalyseMood(message);
        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalysisException))]
        public void TestInvalidMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "Invalid mood message";
            string mood = moodAnalyser.AnalyseMood(message);
        }
    }
}
