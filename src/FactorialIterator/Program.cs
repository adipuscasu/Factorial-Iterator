class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            var factorials = new FactorialEnumerable(n);

            using (StreamWriter writer = new StreamWriter("factorials.txt"))
            {
                foreach (var factorial in factorials)
                {
                    writer.WriteLine(factorial);
                }
            }

            Console.WriteLine("Factorials have been written to factorials.txt");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
