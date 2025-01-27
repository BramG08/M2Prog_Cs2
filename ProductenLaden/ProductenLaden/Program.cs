using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ProductenLaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            program.RunProducten();
            program.Elmo();
        }
     
        internal void RunProducten() 
        {
            string text = File.ReadAllText("Producten.json");
            Product[] product = JsonSerializer.Deserialize<Product[]>(text);

            for (int i = 0; i < product.Length; i++) 
            {
                Console.WriteLine(product[i].Name);
                Console.WriteLine(product[i].Description);
                Console.WriteLine(product[i].Price);
            }
    
        }

        internal void Elmo() 
        {
            string text = File.ReadAllText("elmo.json");
            elmo[] elmo = JsonSerializer.Deserialize<elmo[]>(text);

            
            for (int i = 0; i < elmo.Length; i++)
            {
                Console.WriteLine(elmo[i].Friend);
                Console.WriteLine(elmo[i].DickSize);
                Console.WriteLine(elmo[i].Price);
            }
        }
        internal void Run()
        {
            string text = File.ReadAllText("Product.json");
            Product product = JsonSerializer.Deserialize<Product>(text);

        }
    }
}
