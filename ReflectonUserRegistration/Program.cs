namespace ReflectonUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();
            string firstName = "Battu";
            string lastName = "Sairam";
            string email = "Battusairam@gmail.com";
            string mobile = "91 7036703736";
            string password = "P@ssw0rd123";

            // Test each validation rule using reflection.
            bool isValidFirstName = registration.ValidateAllRules(registration, "ValidateFirstName", firstName);
            bool isValidLastName = registration.ValidateAllRules(registration, "ValidateLastName", lastName);
            bool isValidEmail = registration.ValidateAllRules(registration, "ValidateEmail", email);
            bool isValidMobile = registration.ValidateAllRules(registration, "ValidateMobile", mobile);
            bool isValidPassword = registration.ValidateAllRules(registration, "ValidatePassword", password);

            Console.WriteLine("First Name is Valid: " + isValidFirstName);
            Console.WriteLine("Last Name is Valid: " + isValidLastName);
            Console.WriteLine("Email is Valid: " + isValidEmail);
            Console.WriteLine("Mobile is Valid: " + isValidMobile);
            Console.WriteLine("Password is Valid: " + isValidPassword);
        }
    }
}