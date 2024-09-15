namespace Inlämningsuppgift
{
    // Huvudklassen Skola
    public class Skola
    {
        // Attributer
        public string Namn;
        public string Klass;

        // Metoder
        public void Visainfo()
        {
            Console.WriteLine("Denna skola har olika klasser.");
        }
    }

    // En underklass som är Elev och ärver från Skola
    public class Elev : Skola
    {
        //Elev har samma attributer + nya attributer 
        public string Betyg;

        // Elev har samma metoder + nya metoder
        public new void VisaBetyg()
        {
            Console.WriteLine($"Elev: {Namn}, klass: {Klass}, Betyg: {Betyg}.");
        }
    }
}

