using System;
using System.Collections.Generic;
using System.Text;

namespace MoodTestProject
{
    class MoodAnalysisException : Exception
    {
        public MoodAnalysisError Error { get; }

        public MoodAnalysisException(MoodAnalysisError error, string message) : base(message)
        {
            Error = error;
        }
    }
}
