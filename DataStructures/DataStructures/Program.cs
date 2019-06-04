using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Node<T>
    {
        T Data;
        Node<T> Next;
    }
    class LinkedList<T>
    {
        Node<T> First;
    }
}
