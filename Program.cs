namespace Assignment_2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] numbers = new double[3];
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
                }
            }
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
    }
}
