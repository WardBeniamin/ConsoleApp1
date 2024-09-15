namespace ConsoleApp1
{
    internal class Användare
    {
        private string password;



        public Användare (string password)
        {
            password = password;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }



    }
}
