using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MyList = new LinkedList<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter {i} - th element of the list: ");
                MyList.Add(Console.ReadLine());
            }

            MyList.PrintList();


        }
    }
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T Data)
        {
            this.Data = Data;
        }
    }

    public class LinkedList<T>
    {
        public Node<T> First;

        public LinkedList()
        {
            First = null;
        }

        public void Add(T value)
        {
            Node<T> NewNode = new Node<T>(value);

            if (First == null)
            {
                NewNode.Next = null;
                First = NewNode;
            }

            Node<T> currentNode = First;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = NewNode;
            NewNode.Next = null;
        }

        public void PrintList()
        {
            var currentNode = First;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data + ", ");

                currentNode = currentNode.Next;
            }
        }
    }
}
