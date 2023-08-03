using System;
using System.Collections.Generic;
using System.Text;

namespace MoodTestProject
{
    public class MoodAnalyzer
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
                return "Happy";
            else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                return "Sad";
            return null;
        }
    }
}
