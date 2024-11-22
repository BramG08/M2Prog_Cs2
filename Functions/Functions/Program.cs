namespace Functions
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
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();

        }
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag2()
        {
            Console.WriteLine("The funniest thing that happened in your life?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("what do you call a male ladybug?");
            string antwoord = Console.ReadLine();   
            Console.WriteLine(antwoord);
        }
         internal void Vraag4()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();   
            Console.WriteLine(antwoord);
        }

        internal void Vraag5() 
        { 
            Console.WriteLine("Why are you friends with your friends");
            string antwoord = Console.ReadLine();   
            Console.WriteLine(antwoord);
        }
        internal void Vraag6() 
        {
            Console.WriteLine("How is your family?");
            string antwoord = Console.ReadLine();   
            Console.WriteLine(antwoord);
        }
    }
}
