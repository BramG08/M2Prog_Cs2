using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors03
{
    internal class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal bool goed;
        internal QuizVraagAntwoord(QuizVraag vraag, bool goed)
        {
            this.vraag = vraag;
            this.goed = false;
        }
    }
  

}
