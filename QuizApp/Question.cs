namespace QuizApp
{
    partial class Question
    {
        public  string Title {get;}
        public string [] PossibleAnswers {get;}
        private readonly string correctAnswer = "";
        public Question(string title , string[] possibleAnswers, string correctAnswer)
        {
            Title = title;
            PossibleAnswers = possibleAnswers;
            this.correctAnswer = correctAnswer;
        }
    }
}