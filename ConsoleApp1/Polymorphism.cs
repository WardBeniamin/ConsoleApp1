namespace ConsoleApp1
{
    public class Anställd
    {
        public string Namn;
        public string Arbete;


        public virtual void Arbeta()
        {
            Console.WriteLine($"Alla här har sitt eget jobb.");
        }

        public class Lärare : Anställd
        {
            public override void Arbeta()
            {
                Console.WriteLine($"{Namn} Jobbar som {Arbete}.");
            }

        }
        public class Administratör : Anställd 
        {

            public override void Arbeta()
            {
                Console.WriteLine($"{Namn} jobbar som {Arbete}." );   
            }


        }


    }
}
