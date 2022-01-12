using DSA.Utilities;
using DSA.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CommonProblems
{
    public static class AnagramChecker
    {
        public static bool AreAnagramsByCharacterCount(string wordOne, string wordTwo)
        {
            wordOne = wordOne.ToLower();
            wordTwo = wordTwo.ToLower();

            if (wordOne.Length != wordTwo.Length)
                return false;

            var wordOneLetterCounts = new Dictionary<char, int>();
            var wordTwoLetterCounts = new Dictionary<char, int>();

            for (int i = 0; i < wordOne.Length; i++)
            {
                wordOneLetterCounts.AddOrUpdate(wordOne[i], wordOneLetterCounts.TryGetValue(wordOne[i], out var valueOne) ? valueOne + 1 : default, 1);
                wordTwoLetterCounts.AddOrUpdate(wordTwo[i], wordTwoLetterCounts.TryGetValue(wordTwo[i], out var valueTwo) ? valueTwo + 1 : default, 1);
            }

            foreach (var (key, value) in wordOneLetterCounts)
            {
                if (!wordTwoLetterCounts.ContainsKey(key) || wordTwoLetterCounts[key] != value)
                    return false;
            }

            return true;
        }

        public static bool AreAnagramsBySorting(string wordOne, string wordTwo)
        {
            return new string(wordOne.ToLower().ToCharArray().Sort()) == new string(wordTwo.ToLower().ToCharArray().Sort());
        }
    }
}
