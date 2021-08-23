using System;

namespace MoodAnalyser1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser");

            MoodAnalyser mood = new MoodAnalyser("Sad");
            Console.WriteLine(mood.AnalyseMood());
        }
    }
}
