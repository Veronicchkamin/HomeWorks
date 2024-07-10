namespace Homework4
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            int rowNumber, colNumber;
            while (true)
            {

                Console.Write("Enter number of rows:\n");
                var userInput = Console.ReadLine();
                int.TryParse(userInput, out rowNumber);

                Console.WriteLine("Write number of colums: ");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out colNumber);

                if (rowNumber != default && colNumber != default)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }

            }

            int[,] array = new int[rowNumber, colNumber];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Type massive element: ");
                    var element = Console.ReadLine();
                    array[i, j] = int.Parse(element);
                }
            }

            Console.Clear();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Choose an operation:\n" +
                " 1. Find amount of positive numbers\n" +
                " 2. Find amount of negative numbers\n" +
                " 3. Sort by ascending order\n" +
                " 4. Sort by descending order\n" +
                " 5. Inversion");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    {
                        int positiveCount = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] > 0)
                                {
                                    positiveCount++;
                                }
                            }
                        }

                        Console.WriteLine($"Amount of positive numbers is: {positiveCount}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "2":
                    {
                        int negativeCount = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] < 0)
                                {
                                    negativeCount++;
                                }
                            }
                        }
                        Console.WriteLine($"Amount of negative numbers is: {negativeCount}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "3":
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                for (int k = 0; k < array.GetLength(1) - 1; k++)

                                {

                                    if (array[i, k] > array[i, k + 1])
                                    {
                                        int temp = array[i, k];
                                        array[i, k] = array[i, k + 1];
                                        array[i, k + 1] = temp;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Sort by ascending order");
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {

                                Console.Write(array[i, j] + " ");

                            }
                            Console.WriteLine();
                        }

                        break;

                    }
            }
        }
    }
}
