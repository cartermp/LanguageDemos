using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class IndexAndRange
    {
        public static void Demo()
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine("Words: " + string.Join(", ", words));

            Console.WriteLine($"The last word is {words[^1]}");

            var qbf = words[1..4];
            var quickBrownFox = string.Join(" ", qbf);
            Console.WriteLine($"The quick brown fox: {quickBrownFox}");

            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            Console.WriteLine($"All words: " + string.Join(" ", allWords));
            Console.WriteLine($"First phrase: " + string.Join(" ", firstPhrase));
            Console.WriteLine($"Last phrase: " + string.Join(" ", lastPhrase));
        }
    }
}
