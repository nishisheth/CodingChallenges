using System;
using CodingChallenges.LinkedList;
using CodingChallenges.Strings;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = { 12, 11, 12, 21, 41, 43, 21 };
            Console.WriteLine("Challange # 1: Remove Duplicates from LinkedList");
            RemoveDuplicatesLinkedList removeDuplicates = new RemoveDuplicatesLinkedList();
            removeDuplicates.removeDups(inputNums);

            Console.WriteLine("\n\nChallange # 2: Check if two strings are permutations of each other");
            CheckPermutationofStrings checkPermutations = new CheckPermutationofStrings();
            checkPermutations.CheckPermutation("abc", "bac");

        }
    }
}
