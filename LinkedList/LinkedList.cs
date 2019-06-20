using System;
namespace CodingChallenges.LinkedList
{
    public class LinkedList
    {
        public LinkedList Next { get; set; }

        public int Data { get; set; }

        //contructor to create a node
        public LinkedList(int data)
        {
            Data = data;
            Next = null;
        }

        // Crates new node and inserts in to back of the linked list
        public void InsertLinkedList(LinkedList root, int data)
        {
            LinkedList node = root;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new LinkedList(data);
        }

        // Travers to each node and display's its data elements
        public void Traverse(LinkedList root)
        {
            while (root != null)
            {
                Console.Write(root.Data + " ");
                root = root.Next;
            }
        }

        //Deletes duplicate elements from unsorted linked list
        public void DeleteDuplicate(LinkedList root)
        {
            // if the linked-list is empty or have only root node.
            if (root == null || root.Next == null) return;

            LinkedList currentNode = root;
            LinkedList runningNode;
            LinkedList runningPrev;

            while (currentNode != null)
            {
                runningPrev = currentNode;
                runningNode = currentNode.Next;

                var data = currentNode.Data;

                while (runningNode != null)
                {
                    if (runningNode.Data == data)
                    {
                        runningPrev.Next = runningNode.Next;
                    }
                    else
                    {
                        runningPrev = runningNode;
                    }

                    runningNode = runningNode.Next;
                }

                currentNode = currentNode.Next;
            }
        }
    }
}
