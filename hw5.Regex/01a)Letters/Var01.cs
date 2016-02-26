using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01a_Letters
{
    class Var01
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"(.)\1+");
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}
