using System;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to caluclate using the simple caluclater:");
            string reaction = Console.ReadLine().ToLower();

            while (reaction == "y")
            {
                Console.WriteLine("Enter the first number");
                float number1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter the seconed number");
                float number2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Choose operation");
                char operation = Convert.ToChar(Console.ReadLine());

                float summation = 0;

                switch (operation)
                {
                    case '+':
                        summation = number1 + number2;
                        break;
                    case '-':
                        summation = number1 - number2;
                        break;
                    case '*':
                        summation = number1 * number2;
                        break;
                    case '/':
                        summation = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("indecleared operation");
                        break;
                }
                Console.WriteLine($"The summation of the operation is {summation}");

                Console.WriteLine("Do you want to continue?(yes/No ");
                string calucalteagin = Console.ReadLine();
                if (calucalteagin == "n")
                {
                    Console.WriteLine("Thank you ");
                    break;

                }
            }
            Console.ReadKey();

        }
    }

}
