using System.Collections.Generic;

namespace QuizData
{
    public class TestPaper
    {
        public string SubjectName { get; set; }
        public string TestPaperName { get; set; }
        public List<Question> Questions { get; set; }

        public TestPaper() { }
        public TestPaper(
            string subjectName,
            string testPaperName
            )
        {
            SubjectName = subjectName;
            TestPaperName = testPaperName;
        }

        public override string ToString()
        {
           return $"Test {TestPaperName}. Subject {SubjectName}";
        }
    }
}
