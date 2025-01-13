namespace lists04
{
    internal class Program
  namespace lists04
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
                double[] prijzen = new double[] { 0.99, 5.60, 10.11, 4.50 };

                string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "broodje shoarma" };

                Formulier[] formulieren = new Formulier[2];


                formulieren[0] = new Formulier()
                {
                    Feedback = "prijzig maar lekker",
                    Sterren = 5
                };
                formulieren[1] = new Formulier()
                {
                    Feedback = "prijzig en smaakt naar Dikke vette stront",
                    Sterren = 1
                };
                for (int i = 0; i < prijzen.Length; i++)
                {
                    Console.WriteLine(prijzen[i]);
                    Console.WriteLine(artiekelen[i]);
                }
                foreach (Formulier formulier in formulieren)
                {
                    Console.WriteLine(formulier.Feedback);
                    Console.WriteLine(formulier.Sterren);
                }

                List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };

                reviews.Remove(342.97);

                foreach (double review in reviews)
                {
                    Console.WriteLine(review);
                }

            }
        }
    }

}
