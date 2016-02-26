using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Problem_4.Sentence_Extractor
{
    class Sentenceextractor
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", word);
            Regex regexSentence = new Regex(pattern);
            MatchCollection matches = regexSentence.Matches(text);
            Console.WriteLine("Found {0} matches", matches.Count);
            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}
