using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string text = @"Hello, my phone number is 0123456789, my address is rue Voltaire 145. " +
                       "the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any questions " +
                       "the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any questions " +
                       "Our customer care representatives are available to assist you 24 hours a day, 7 days a week on: 0000000000, 9999999999 and 0777778899";

        foreach (Match match in Regex.Matches(text, @"\b0\d{9}\b"))
        {
            string number = match.Value;
            if (a(number))
                Console.WriteLine(number);
        }

        static bool a(string number)
        {
            return number.Distinct().Count() >= 2;
        }
    }
}