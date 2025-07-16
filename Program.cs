namespace Assignment_2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] numbers = new double[3];
            int counter = 0;
            Console.WriteLine("Input three numbers: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Number {i + 1}: ");
                double input = Convert.ToDouble(Console.ReadLine());
                numbers[i] = input;
            }
            double maxNumber = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                    counter = i + 1; // Store the index of the largest number

                }
            }
            string winner = "";
            switch (counter)
            {
                case 1:
                    winner = "first";
                    break;
                case 2:
                    winner = "second";
                    break;
                case 3:
                    winner = "third";
                    break;
                default:
                    Console.WriteLine("No valid number found.");
                    break;
            }

            Console.WriteLine($"The largest number is: {maxNumber}, which is the {winner} number");

        }
    }
}
