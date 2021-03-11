using System;
using System.Linq;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Subtask1
            
            /* String name = "Даниїл";
            Console.WriteLine("Введіть ім'я: ");
            name = Console.ReadLine(); 
            String city = "Чернівці";
            Console.WriteLine("Введіть місто: ");
            city = Console.ReadLine(); 
            Console.WriteLine(name + " живе у місті " + city); */

            //Subtask2

            /* String first = "";
            Console.WriteLine("Input first string: ");
            first = Console.ReadLine();
            String second = "";
            Console.WriteLine("Input second string: ");
            second = Console.ReadLine();
            String third = first.Substring((first.Length-3)) + second.Substring(0,3);
            Console.WriteLine("Result: "+ third); */

            //Subtask3

            /* String input = "тонна";
            String result = "";
            result = result+input[2]+input[1]+input[0]+input[4];
            Console.WriteLine(result); */

            //Subtask4
            
            String input = "від відра до відра";
            input = input.Replace("від","до");
            Console.WriteLine(input);

            
        }
    }
}
