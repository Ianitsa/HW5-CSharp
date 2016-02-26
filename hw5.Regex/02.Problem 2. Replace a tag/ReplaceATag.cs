using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Problem_2.Replace_a_tag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(<a href=)(.*(?=>))(>)(.*(?=<))(</a>)";
            string replace = @"[URL href=$2]$4[/URL]";
            var replaced = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replaced);
        }
    }
}
