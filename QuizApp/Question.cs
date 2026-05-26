namespace QuizApp
{
    partial class Question
    {
        public  string Title {get;}
        private readonly string [] possibleAnswers = [];
        private readonly string correctAnswer = "";
        public Question(string title , string[] possibleAnswers, string correctAnswer)
        {
            Title = title;
            this.possibleAnswers = possibleAnswers;
            this.correctAnswer = correctAnswer;
        }
    }
}