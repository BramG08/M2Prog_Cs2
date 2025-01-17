using System.Reflection;

namespace Dictionaries
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
            Dictionary<int, string> personeel = new Dictionary<int, string>();
            personeel.Add(382942, "Jermaine");
            personeel.Add(789432, "Timothy");

        

            foreach (KeyValuePair<int, string> item in personeel)
            {
                Console.WriteLine(item.Value + ": "+ item.Key);
            }
            foreach (int key in personeel.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string value in personeel.Values) 
            {
                Console.WriteLine(value);
            }
        }

    }
}
