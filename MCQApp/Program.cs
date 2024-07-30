
using QuizData;
using System;

namespace MCQApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            QuizSystem quizSystem = new QuizSystem();
            quizSystem.TakeTest();
            Console.ReadKey();

        }
    }
}
