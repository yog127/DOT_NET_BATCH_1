using System;
namespace LinkList
{
    public class SinglyLinkedList
    {
        public Node headNode;

    public SinglyLinkedList()
    {
        headNode = null;
    }
    public void InsertSorted(int data)
    {
        Node newNode = new Node(data);

        if (headNode == null || headNode.data >= data)
        {
            newNode.next = headNode;
            headNode = newNode;
        }
        else
        {
            Node dataC = headNode;
            while (dataC.next != null && dataC.next.data < data)
            {
                dataC = dataC.next;
            }

            newNode.next = dataC.next;
            dataC.next = newNode;
        }
    }
    public void PrintList()
    {
        Node trav = headNode;
        while (trav != null)
        {
            Console.Write(trav.data + " ");
            trav = trav.next;
        }
        Console.WriteLine("List is Null");
    }
    }
}
