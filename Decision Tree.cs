using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Do you want some tea? (yes/no)");
        string teaResponse = Console.ReadLine().ToLower();

        if (teaResponse == "yes")
        {
            Console.WriteLine("With sugar? (yes/no)");
            string sugarResponse = Console.ReadLine().ToLower();
            Console.WriteLine(sugarResponse == "yes" ? "Here is your tea with sugar." : "Here is your tea without sugar.");
        }
        else if (teaResponse == "no")
        {
            Console.WriteLine("Do you want some coffee? (yes/no)");
            string coffeeResponse = Console.ReadLine().ToLower();

            if (coffeeResponse == "yes")
            {
                Console.WriteLine("With sugar? (yes/no)");
                string sugarResponse = Console.ReadLine().ToLower();
                Console.WriteLine(sugarResponse == "yes" ? "Here is your coffee with sugar." : "Here is your coffee without sugar.");
            }
            else
            {
                Console.WriteLine("So you don't want anything.");
            }
        }
        else
        {
            Console.WriteLine("Please answer with 'yes' or 'no'.");
        }
    }
}