namespace Methods_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks user to enter whole number and prints to console
            Console.WriteLine("Enter a whole number.");
            int x = Convert.ToInt32(Console.ReadLine());
            // asks user to enter another whole number and prints to console
            Console.WriteLine("Enter another a whole number.");
            int y = Convert.ToInt32(Console.ReadLine());

            // prints multiplied numbers to console
            Console.WriteLine(Multiply(x,y));

            // asks user to enter name and prints it to console
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        /// <summary>
        /// multiplies num1 and num2 together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Multiply(int num1, int num2)
        {
                return num1 * num2;
        }

        /// <summary>
        /// prints out welcome message to console
        /// </summary>
        /// <param name="username"></param>
        static void WelcomeUser(string username) 
        {
                Console.WriteLine($"Hey, {username} glad you're here.");
        }

        /// <summary>
        /// prints a goodbye method to console
        /// </summary>
        static void Goodbye()
        {
            Console.WriteLine("Have a nice day.");
        }
    }
}