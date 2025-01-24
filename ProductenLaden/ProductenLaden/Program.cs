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
        }
        static void RunProducten(string[] args)
        {
            Program program = new Program();
            program.RunProducten();
        }
        internal void RunProducten() 
        {
            string text = File.ReadAllText("Producten.json");
            Product[] product = JsonSerializer.Deserialize<Product[]>(text);
          
            Console.WriteLine(product);

            for (int i = 0; i < product.Length; i++) 
            {
                Console.WriteLine(product[i]);
            }
    
        }
        internal void Run()
        {
            string text = File.ReadAllText("Product.json");
            Product product = JsonSerializer.Deserialize<Product>(text);

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);


           
        }
    }
}
