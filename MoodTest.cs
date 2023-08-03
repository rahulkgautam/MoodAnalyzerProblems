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
        public void TestUnknownMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = "This is just a regular message.";
            string mood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("Unknown", mood);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNullMessage()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = null;
            string mood = moodAnalyser.AnalyseMood(message);
        }
    }
}
