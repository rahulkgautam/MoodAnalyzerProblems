using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodTestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestCreateMoodAnalyser()
        {
            MoodAnalyser moodAnalyser = MoodAnalyserFactory.CreateMoodAnalyser();
            Assert.IsNotNull(moodAnalyser);
        }
    }
}
