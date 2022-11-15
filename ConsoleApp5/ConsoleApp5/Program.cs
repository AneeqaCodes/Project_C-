using System;
namespace LibLoginValidator
{
    class LoginValidator
    {
        public string Username
        {
            get; set;
        }
        public string Password
        {
            get; set;
        } //constructor
       public LoginValidator() { 
        Username = null; Password = null; } //returns a bool? (nullable bool) value 
    public bool? Authorise()
    {
        if (Username == null || Password == null)
            return null;
        else if ((Username.Equals("wayne") && Password.Equals("bryan")) || (Username.Equals("john") && Password.Equals("wick")) || (Username.Equals("tim") && Password.Equals("cook")))
        {
            return true;
        }
        else return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        LoginValidator validator = new LoginValidator();
        bool status = false;
        do
        {
            Console.Write("Enter user name: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (user.Length == 0) validator.Username = null;
            else validator.Username = user;
            if (password.Length == 0) validator.Password = null;
            else validator.Password = password;
            bool? result = validator.Authorise();
            if (result == null)
            {
                Console.WriteLine("both username and password are required.");
            }
            else if (!result.Value)
            {
                Console.WriteLine(" the authorization has failed.");
            }
            else
            {
                Console.WriteLine(" the authorization was successful.");
                status = true;
            }
        }
        while (!status);//pause 
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
} } 

