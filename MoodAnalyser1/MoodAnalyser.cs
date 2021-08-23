﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser1
{
    public class MoodAnalyser
    {
        // instance variable
        private string message;

        // constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        // method to analyse mood
        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
