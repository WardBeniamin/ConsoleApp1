namespace ConsoleApp1
{
    public abstract class  Flyplan
    {
        public abstract void Flyga();
    }
    

    public class Helikopter : Flyplan
    {
        public override void Flyga()
        {
            Console.WriteLine("Helikopter flyger"); 
        }
    }



    
}
