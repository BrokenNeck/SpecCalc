namespace SpecCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            var inputValue = Console.ReadLine();

            if (int.TryParse(inputValue, out var inputAsInt)) {
                OddOrEven(inputAsInt);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void OddOrEven(int number)
            {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is prime.");
            }
            else{
                Console.WriteLine($"{number} is odd.");
                }
        }
    }
}
