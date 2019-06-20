using System;
namespace CodingChallenges.LinkedList
{
    public class RemoveDuplicatesLinkedList
    {

        public void removeDups(int[] inputNumbers)
        {
            LinkedList root = new LinkedList(inputNumbers[0]);

            for (int i = 1; i < inputNumbers.Length; i++)
            {
                root.InsertLinkedList(root, inputNumbers[i]);
            }

            Console.WriteLine("Before Deleting:");
            root.Traverse(root);
            root.DeleteDuplicate(root);
            Console.WriteLine("\nAfter Deleting duplicate numbers:");
            root.Traverse(root);
        }

    }
}
