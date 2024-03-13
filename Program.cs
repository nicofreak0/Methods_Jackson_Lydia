namespace Methods_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another a whole number.");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiply(x,y));
        }

        static int Multiply(int num1, int num2)
        {
                return num1 * num2;
        }

    }
}