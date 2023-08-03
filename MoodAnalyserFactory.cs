using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodTestProject
{
    class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser(string message)
        {
            Type moodAnalyserType = typeof(MoodAnalyser);
            ConstructorInfo constructor = moodAnalyserType.GetConstructor(new Type[] { typeof(string) });
            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(new object[] { message });
            return moodAnalyser;
        }
    }
}
