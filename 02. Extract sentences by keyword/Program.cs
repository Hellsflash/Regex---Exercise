using System;
using System.Text.RegularExpressions;

namespace _02.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine().Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = "\\b" + word + "\\b";
            Regex regex = new Regex(pattern);
            foreach (var santance in text)
            {
                if (regex.IsMatch(santance))
                {
                    Console.WriteLine(santance.Trim());
                }
            }
        }
    }
}
