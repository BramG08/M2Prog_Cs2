namespace MemSave
{
    internal class Program
    {
        string saveFile = "welkomState.txt";
        string welkomsTekst = "hello world";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run() 
        {
            bool bestaatDeFile = File.Exists(saveFile);
            if (bestaatDeFile == true)
            {
                welkomsTekst = File.ReadAllText(saveFile);
                Console.WriteLine(welkomsTekst);
            }
            
            while (true) 
            {
                Console.WriteLine(welkomsTekst);
                Console.WriteLine("Enter a text ,then press enter");
                welkomsTekst = Console.ReadLine();
                File.WriteAllText(saveFile, welkomsTekst);
                
            }
        }
    }
}
