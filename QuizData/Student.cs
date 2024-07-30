using System.Collections.Generic;

namespace QuizData
{
    public class Student
    {
        public int RollNo {  get; set; }

        public string StudentName { get; set; }

        public List<TestPaper> TestPapers { get; set; }

        public override string ToString()
        {
            return $"Student {StudentName} With id {RollNo}";
        }
    }
}
