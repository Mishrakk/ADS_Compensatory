﻿using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Node<T>
    {
        T Data;
        public Node<T> Next;

        public Node(T Data)
        {
            this.Data = Data;
        }
    }

    public class LinkedList<T>
    {
        Node<T> First;

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
    }
}
