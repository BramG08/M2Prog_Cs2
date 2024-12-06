namespace constructors03
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
        internal int Score;
        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }
        internal void StelVraag(int index)
        {
            QuizVraag vraag = vragen[index];
            QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);
            Console.WriteLine(vraag.vraag);
            string antwoord = Console.ReadLine();

            quizVraagAntwoord.goed = antwoord == vraag.antwoord;

            if (quizVraagAntwoord.goed) 
            {
                Score++;
            }
        }
        internal int GetScore()
        {
            return Score;
        }
       
              
        
    }
   
}
