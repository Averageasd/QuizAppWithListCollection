using System.Collections.Generic;
using System.Text;

namespace QuizData
{
    public class Question
    {
        public const int score = 10;
        public string QuestionText { get; set; }
        public List<Option> Options { get; set; }
        public char CorrectAnswerLetter { get; set; }
        public char OptionSelectedByStudent { get; set; }
        public int MarksSecured { get; set; }

        public Question() { }
        public Question(
            string questionText,
            List<Option> options,
            char correctAnswerLetter
            )
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswerLetter = correctAnswerLetter;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(QuestionText).Append("\n");
            for(int i = 0; i < Options.Count;i++)
            {
                Option curOpt = Options[i];
                stringBuilder.Append(curOpt);
                if (i < Options.Count - 1)
                {
                    stringBuilder.Append("\n");
                }
            }
            return stringBuilder.ToString();
        }


    }
}
