namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after teh 1995 film?",
            "What arcade game was called Puckman in Japan?",
            "What video game came with the Nintendo Entertainment System when it was released in the late 1980s, and was meant to be played with the NES Zapper gun?"
        };

        internal string GetVraag(int vraagIndex )
        {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            Random rand = new Random();
            int randint = rand.Next(0, vragen.Length);
            return vragen[randint];

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void AskRandomQuestion()
        {
            string RandomVraag = GetRandomVraag();
            Console.WriteLine(RandomVraag);
        }
        internal void Run()
        {
            string vraag0 = GetVraag(0);
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
            Console.WriteLine(GetRandomVraag());
        }
        internal string Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            return antwoord;
        }
        internal string Vraag2()
        {
            Console.WriteLine("The funniest thing that happened in your life?");
            string antwoord = Console.ReadLine();

            return antwoord;
        }

        internal string Vraag3()
        {
            Console.WriteLine("what do you call a male ladybug?");
            string antwoord = Console.ReadLine();   
            return antwoord ;
        }
         internal string Vraag4()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();   
            return antwoord ;
        }

        internal string Vraag5()
        {
            Console.WriteLine("Why are you friends with your friends");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
            internal string Vraag6() 
        {
            Console.WriteLine("How is your family?");
            string antwoord = Console.ReadLine();   
            return antwoord ;
        }
    }
}
