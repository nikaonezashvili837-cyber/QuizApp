namespace QuizApp
{
    partial class Question
    {
        public  string Title {get;}
        public string [] PossibleAnswers {get;}
        public string CorrectAnswer {get;}
        public Question(string title , string[] possibleAnswers, string correctAnswer)
        {
            Title = title;
            PossibleAnswers = possibleAnswers;
            this.CorrectAnswer = correctAnswer;
        }
    }
}