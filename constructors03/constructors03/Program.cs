using System.Runtime.CompilerServices;

namespace constructors03
{
    internal class Program
    {
        Quiz Quiz = new Quiz(10);
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            QuizVraagToeOpIndex(0, "vraag", "antwoord");
            QuizVraagToeOpIndex(1, "vraag", "antwoord");
            QuizVraagToeOpIndex(2, "vraag", "antwoord");
            QuizVraagToeOpIndex(3, "vraag", "antwoord");
            QuizVraagToeOpIndex(4, "vraag", "antwoord");
            QuizVraagToeOpIndex(5, "vraag", "antwoord");
            QuizVraagToeOpIndex(6, "vraag", "antwoord");
            QuizVraagToeOpIndex(7, "vraag", "antwoord");
            QuizVraagToeOpIndex(8, "vraag", "antwoord");
            QuizVraagToeOpIndex(9, "vraag", "antwoord");

            for (int i = 0; i < Quiz.vragen.Length; i++)
            {
                Quiz.StelVraag(i);
                Console.WriteLine("Je score is: " + Quiz.GetScore().ToString());
            }

        }


        internal void QuizVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
            Quiz.VoegVraagToeOpIndex(index, quizVraag);
        }
            
    }
}
