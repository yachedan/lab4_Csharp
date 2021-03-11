using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "Lorem ipsum, indocrate at uplue as vart. Nostrud sprat atu spardu.";
            char[] separators = new char[] {' ','.',','};
            String[] subs = input.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            String result = "";
            foreach(var sub in subs)
            {
                if(sub.Length%2==0)
                    result = result+sub+" ";
            }
            Console.WriteLine(result);
        }
    }
}
