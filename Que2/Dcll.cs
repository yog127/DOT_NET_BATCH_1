using System;
namespace DataStructure
{
    public class DoublyCircularLinkedList<T> 
    {
        private DNode<T> headNode;

        public DoublyCircularLinkedList()
        {
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }
        public void InsertBegin(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            GenericInsert(headNode, newNode, headNode.Next);
            Console.WriteLine("Insert Begin");
        }
        public void InsertEnd(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            GenericInsert(headNode.Prev, newNode, headNode);
        }

        public bool Find(T data)
        {
            DNode<T> tempNode = headNode.Next;
            while(tempNode != null && tempNode != headNode)
            {
                if(tempNode.Data.Equals(data))
                {
                    Console.WriteLine("Element is found :" + data);
                    return true;
                }
                tempNode = tempNode.Next;
            }
            Console.WriteLine("Element is Not  found ");
            return false;
        }

        public void Merg(list1 obj1 ,list2 obj2)
        {

        }

        public void Reverse()
       {
        if (head == null) 
        {
            Console.WriteLine("List is Empty");
        }

        DNode<T> temp = headNode.prev; 
        while (temp != head.prev);
        {
            headNode=temp.data;
            temp = temp.prev;
        } 
    }
        public void LinkListToArray()
    {
        arr[]= new Array;
        int count = 0;
        if (head == null) 
        {
            Console.WriteLine("List is Empty ");
        }
        DNode<T> tempNode = head;

        while (tempNode != head)
        {
            count++;
            tempNode = tempNode.next;
        } 
        for(int i=0;i<count;i++){
        arr[i] =tempNode.data;
        }
    }
        private static void GenericInsert(DNode<T> start, DNode<T> mid, DNode<T> end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;
        }
        private static void GenericDelete(DNode<T> deleteNode)
        {
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }
        public void PrintList()
        {
            DNode<T> tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                Console.Write(" " + tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("[END]");
        }
    }
}