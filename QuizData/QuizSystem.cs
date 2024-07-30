using System;
using System.Collections.Generic;

namespace QuizData
{
    public class QuizSystem
    {
        private TestPaper paper1;
        public QuizSystem()
        {
            paper1 = new TestPaper();
            InitPaper();
            //PrintPapers();
        }

        public void InitPaper()
        {
            Question q1 = new Question
                (
                "What is a car",
                new List<Option>(){
                    new Option (Option.OPTION_A,"A toy"),
                    new Option (Option.OPTION_B,"A computer"),
                    new Option (Option.OPTION_C,"A gaming device"),
                    new Option (Option.OPTION_D,"A vehicle")
                },
                Option.OPTION_D);
            Question q2 = new Question(
                "what is a phone?",
                new List<Option>(){
                    new Option (Option.OPTION_A,"A tool used for communication"),
                    new Option (Option.OPTION_B,"A toy"),
                    new Option (Option.OPTION_C,"A weapon"),
                    new Option (Option.OPTION_D,"A vehicle")
                },
                Option.OPTION_A);
            paper1.SubjectName = "Common Knowledge";
            paper1.TestPaperName = "test1";
            paper1.Questions = new List<Question> { q1, q2 };
        }

        public void TakeTest()
        {
            int totalScore = 0;
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Nguyen";
            Console.WriteLine($"{student} takes test {paper1}");
            Console.WriteLine(paper1.Questions[0]);
            paper1.Questions[0].OptionSelectedByStudent = Option.OPTION_A;
            paper1.Questions[0].MarksSecured = 0;
            Console.WriteLine($"Student choose {paper1.Questions[0].OptionSelectedByStudent}. Correct answer is {paper1.Questions[0].CorrectAnswerLetter}. Secured mark is {paper1.Questions[0].MarksSecured}");

            Console.WriteLine();


            Console.WriteLine(paper1.Questions[1]);
            paper1.Questions[1].OptionSelectedByStudent = Option.OPTION_A;
            paper1.Questions[1].MarksSecured = 10;
            totalScore += paper1.Questions[1].MarksSecured;
            Console.WriteLine($"Student choose {paper1.Questions[1].OptionSelectedByStudent}. Correct answer is {paper1.Questions[1].CorrectAnswerLetter}. Secured mark is {paper1.Questions[1].MarksSecured}");

            Console.WriteLine($"Total score is {totalScore}");

        }

        //public void PrintPapers()
        //{
        //    foreach (Question q in paper1.Questions)
        //    {
        //        Console.WriteLine(q);
        //        Console.WriteLine();
        //    }
        //}

        //public List<Question> CreateQuestions()
        //{
        //    return null;
        //}

        //public List<Option> CreateOptions()
        //{
        //    return null;
        //}

        //public Question CreateQuestion()
        //{
        //    return null;
        //}

        //public Option CreateOption()
        //{
        //    return null;
        //}
    }
}
