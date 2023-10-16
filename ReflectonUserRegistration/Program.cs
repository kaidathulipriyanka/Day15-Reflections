namespace ReflectonUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();
            string firstName = "Priya";
            string lastName = "prasanya";
            string email = "Kaidhathulipriyanka@gmail.com";
            string mobile = "91 8179664954";
            string password = "priya@123";

            bool isValidFirstName = registration.ValidateAllRules(registration, "ValidateFirstName", firstName);
             Console.WriteLine("First Name is Valid: " + isValidFirstName);
            bool isValidLastName = registration.ValidateAllRules(registration, "ValidateLastName", lastName);
             Console.WriteLine("Last Name is Valid: " + isValidLastName);
            bool isValidEmail = registration.ValidateAllRules(registration, "ValidateEmail", email);
            Console.WriteLine("Email is Valid: " + isValidEmail);
            bool isValidMobile = registration.ValidateAllRules(registration, "ValidateMobile", mobile);
            Console.WriteLine("Mobile is Valid: " + isValidMobile);
            bool isValidPassword = registration.ValidateAllRules(registration, "ValidatePassword", password);
            Console.WriteLine("Password is Valid: " + isValidPassword);
        }
    }
}
