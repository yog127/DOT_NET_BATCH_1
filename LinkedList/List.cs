using System;

namespace DataStructure
{
    internal class List
    {
        private Node headNode;

        public List()
        {
            headNode = new Node(); 
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }
        public void InsertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }
        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Prev, newNode, headNode);
        }
        public void InsertAtPos(int data, int pos)
        {
            Node newNode = new Node(data);
            int counter = 1;
            Node tempNode = headNode.Next;

            while (tempNode != headNode && counter < pos)
            {
                counter++;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.Prev, newNode, tempNode);
        }
        public void InsertAfter(int data, int dataAfter)
        {
            Node newNode = new Node(data);
            Node tempNode = headNode.Next;

            while (tempNode != headNode && tempNode.Data != dataAfter)
            {
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode, newNode, tempNode.Next);
        }
        public int RemoveAtBegin()
        {
            if (headNode.Next == headNode)
            {
                return 1;
            }
            int removedData = headNode.Next.Data;
            GenericDelete(headNode.Next);
            return removedData;
        }
        
        public int RemoveAtPos(int pos)
        {
            int counter = 1;
            Node tempNode = headNode.Next;

            while (tempNode != headNode && counter < pos)
            {
                counter++;
                tempNode = tempNode.Next;
            }

            if (tempNode != headNode)
            {
                int removedData = tempNode.Data;
                GenericDelete(tempNode);
                return removedData;
            }
            else
            {
                Console.WriteLine("Position is out of range.");
                return 0;
            }
        }
        public int RemoveAtEnd()
        {
            if (headNode.Prev == headNode)
            {
                return 1;
            }
            int removedData = headNode.Prev.Data;
            GenericDelete(headNode.Prev);
            return removedData;
        }
        public int FindLength()
        {
            int length = 0;
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                length++;
                tempNode = tempNode.Next;
            }
            Console.WriteLine("Length is "+length);
            return length;
        }

        public bool FindElement(int data)
        {
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                if (tempNode.Data == data)
                {
                    Console.WriteLine("Element is Founded....");
                    return true;
                }
                tempNode = tempNode.Next;
            }

            return false;
        }
        private static void GenericInsert(Node start, Node mid, Node end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;
        }
        private static void GenericDelete(Node deleteNode)
        {
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }
        public void PrintList()
        {
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                Console.Write("[" + tempNode.Data + "]->");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("[END]");
        }
    }
}
