// See https://aka.ms/new-console-template for more information

namespace Calculator

{
    internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("Choose + for addition");
        Console.WriteLine("Choose - for subtraction");
        Console.WriteLine("Choose * for multiplication");
        Console.WriteLine("Choose / for division");

        switch (Console.ReadLine())
        {
            case "+":
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case "":
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case "3":
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case "4":
                Console.WriteLine(firstNumber / secondNumber);
                break;
            default:
                Console.WriteLine("You haven't made your choice");
                break;

        }


    }
}
}
