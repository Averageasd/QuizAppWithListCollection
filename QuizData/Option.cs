
namespace QuizData
{
    public class Option
    {
        public const char OPTION_A = 'A';
        public const char OPTION_B = 'B';
        public const char OPTION_C = 'C';
        public const char OPTION_D = 'D';
        public char OptionLetter { get; set; }
        public string OptionText { get; set; }

        public Option() { }
        public Option(char option, string optionText)
        {
            OptionLetter = option;
            OptionText = optionText;
        }

        public override string ToString()
        {
            return $"{OptionLetter}. {OptionText}"; 
        }
    }
}
