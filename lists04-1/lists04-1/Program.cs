using System;
using System.Runtime.Intrinsics.Wasm;

namespace lists04_1
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
            string[] characters =
                [
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro The Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
                ];
            List<string> characterList = new List<string>();
            characterList.Add("Jonesy The First");

            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }
            foreach (string character in characters)
            {
                Console.WriteLine(character);
            }
        }
    }
}
