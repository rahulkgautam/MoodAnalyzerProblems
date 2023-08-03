using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodTestProject
{
    class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser()
        {
            Type moodAnalyserType = typeof(MoodAnalyser);
            ConstructorInfo constructor = moodAnalyserType.GetConstructor(Type.EmptyTypes);
            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(null);
            return moodAnalyser;
        }
    }
}
