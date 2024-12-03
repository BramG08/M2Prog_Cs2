using System.Runtime.CompilerServices;

namespace constructors03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            QuizVraag quizvraah = new QuizVraag("hier komt de vraag", "hier komt het antwoord");

        }
    }
}
