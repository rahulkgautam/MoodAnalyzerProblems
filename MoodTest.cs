using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodTestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestCreateMoodAnalyserWithMessage()
        {
            string message = "I am feeling Happy today!";
            MoodAnalyser moodAnalyser = MoodAnalyserFactory.CreateMoodAnalyser(message);
            Assert.IsNotNull(moodAnalyser);
        }
    }
}
