namespace QuizApp
{
    partial class Program
    {
        public static void Main()
        {
            Question[] questionsArray = [
                new Question("What is capital of France", ["1. New york", "2.Rome", "3.Paris", "4.Berlin"], "3"),
                new Question("What is 2 + 2?",[ "1. 3", "2. 4", "3. 5", "4. 6" ],"2"),
                new Question("Which color is the sky on a clear day?",["1. Green", "2. Blue", "3. Red", "4. Yellow" ],"2"),
            ];
            string QuestionBox = @"
            +----------------------+
            |     QUESTION         |
            +----------------------+
                                ";
            Console.WriteLine(@"
            ========================================
            WELCOME TO QUIZ APP
            ========================================
            ");
            byte i = 0;
            byte correctAnswers = 0;
            while (i < questionsArray.Length)
            {
                Question question = questionsArray[i];
                Console.WriteLine(QuestionBox);
                Console.WriteLine(question.Title);
                foreach (string el in question.PossibleAnswers)
                {
                    Console.WriteLine(el);
                }
                string? answer = Console.ReadLine();
                correctAnswers+=CheckAnswer(answer,question);
                i++;
            }
            Console.WriteLine($"Correct answers: {correctAnswers} out of 3");
        }
        public static byte CheckAnswer(string? answer, Question question)
        {
            if (answer == question.CorrectAnswer)
            {
                Console.WriteLine("Correct answer");
                return  1;
            }
            Console.WriteLine("Wrong answer");
            return 0;
        }
    }
}