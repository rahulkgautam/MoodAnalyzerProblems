using System;
using System.Collections.Generic;
using System.Text;

namespace MoodTestProject
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new MoodAnalysisException(MoodAnalysisError.NullMessage, "Message cannot be null or empty.");
            }
            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "Happy";
            }
            else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad";
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisError.InvalidMood, "Invalid mood provided.");
            }
        }
    }
}
