namespace QuizApp
{
    partial class Program
    {
        public static void Main()
        {
            Question[] questionsArray = [
                new Question("What is capital of France", ["1. New york", "2.Rome", "3.Paris", "4.Berlin"], "3.Paris"),
                new Question("What is 2 + 2?",[ "1. 3", "2. 4", "3. 5", "4. 6" ],"2. 4"),
                new Question("Which color is the sky on a clear day?",["1. Green", "2. Blue", "3. Red", "4. Yellow" ],"2. Blue"),
            ];
            string QuestionBox = @"+----------------------+
|                                    QUESTION             |
                                   +----------------------+
                                ";
            Console.WriteLine(@"
            ========================================
            WELCOME TO QUIZ APP
            ========================================
            ");
        }
    }
}