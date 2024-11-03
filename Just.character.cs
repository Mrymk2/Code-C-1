class Program
{
    static void Main (string[] args)
    {
        char input;

        do
        {
            Console.Write("input:");

            input = Console.ReadKey().KeyChar;

        } while (char.IsDigit(input));

        Console.WriteLine("\n:" + input);
    }
}