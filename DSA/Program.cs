using DSA.CommonProblems;
using DSA.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA;

public static class Program
{
    static void Main(string[] args)
    {
        var wordOne = "gardener";
        var wordTwo = "dangerxx";

        var isAnagram = AnagramChecker.AreAnagramQuick(wordOne, wordTwo);

        Console.ReadLine();
    }
}