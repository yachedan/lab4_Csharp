using System;
using System.IO;
using System.Text.RegularExpressions;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = File.ReadAllText(@"text.txt");
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(input);
            int max = 0;
            while(match.Success)
            {
                if(Convert.ToInt32(match.Value)>max)
                    max = Convert.ToInt32(match.Value);
                match = match.NextMatch();
            }
            Console.WriteLine("Max value: "+max);
        }
    }
}
