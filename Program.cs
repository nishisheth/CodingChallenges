using System;

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

        }
    }
}
