using System;
using System.IO;
using System.Text.RegularExpressions;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = File.ReadAllText(@"text.txt");
            Regex regex = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(matches.Count + " matches found:");
            foreach(Match match in matches)
                Console.WriteLine(match.Value);
            byte menu = 0;
            Console.WriteLine("Select:\n1) Replace\n2)Delete");
            menu = Convert.ToByte(Console.ReadLine());
            if(menu == 1)
            {               
                String replace = "";
                Console.WriteLine("Input a string: ");
                replace = Console.ReadLine();
                foreach(Match match in matches)
                    input = input.Replace(match.Value,replace);
                Console.WriteLine(input);
            }
            if(menu == 2)
            {
                String delete = "";
                Console.WriteLine("Input a string to delete: ");
                delete = Console.ReadLine();
                foreach(Match match in matches)
                    if(match.Value==delete)
                        input = input.Replace(delete,"");
                Console.WriteLine(input);
            }
        }
    }
}
