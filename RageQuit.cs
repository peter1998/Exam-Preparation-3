
namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Text;


    public class Exceptions
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder sb = new StringBuilder();
            Regex regex = new Regex(@"(\D+)(\d+)");
            Match match = regex.Match(input);

            do
            {
                string stringToAppend = match.Groups[1].Value;
                int counter = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < counter; i++)
                {
                    sb.Append(stringToAppend);
                }
                match = match.NextMatch();
            } while (match.Success);

            int count = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(sb);
        }
    }
}
