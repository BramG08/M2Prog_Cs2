namespace RijSchool
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

            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };


            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo

            };
            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,

                tijd = 1130
            };

            LesPakket lesPakket = new LesPakket()
            {
                urenGekocht = 30,
                urenVerbruikt = 25,

            };
            Student student = new Student() 
            { 
                LesPakket = lesPakket,
                TheorieTest = TheorieTest,
                RijTest = RijTest,
                RijLeraar = rijLeraar,
                leeftijd = 35,
                naam = "Bib"
            }
                
        }
    }
}
