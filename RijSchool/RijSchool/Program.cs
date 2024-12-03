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
                merk = "volvo",

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

            LesUur lesUur1 = new LesUur()
            {
                auto = auto2,
                rijLeraar = rijLeraar,

                tijd = 1000
            };

            LesPakket lesPakket = new LesPakket()
            {
                urenGekocht = 30,
                urenVerbruikt = 25,

            };
            RijTest rijTest = new RijTest()
            {
                afnameDatum = DateTime.Now,
                gehaald = true,

            };

            TheorieTest theorieTest = new TheorieTest()
            {

            };
            Student student1 = new Student()
            {
                LesPakket = lesPakket,
                TheorieTest = theorieTest,
                RijsTest = rijTest,
                RijLeraar = rijLeraar,
                leeftijd = 35,
                naam = "Bib"
            };
            Student student2 = new Student()
            {
                LesPakket = lesPakket,
                TheorieTest = theorieTest,
                RijsTest = rijTest,
                RijLeraar = rijLeraar,
                leeftijd = 33,
                naam = "Bub"
            };

            Student[] students = new Student[] { student1, student2 };
            LesUur[] lesUurs = new LesUur[] { lesUur, lesUur1 };

            Dag dag = new Dag()
            {
                datum = DateTime.Now,
                lesuren = lesUurs,

            };


        }
    }
}
