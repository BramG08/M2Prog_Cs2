namespace constructors03
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
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
            QuizVraagAntwoord antwoord = ingevuldeAntwoorden[index];
        }
    }
   
}
