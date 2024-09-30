using System;
namespace LinkList
{
class MainClass
{
    public static void Main(String[] args)
    {
        SinglyLinkedList li = new SinglyLinkedList();
        li.InsertSorted(10);
        li.InsertSorted(5);
        li.InsertSorted(20);
        li.InsertSorted(15);

        li.PrintList(); 
    }
}
}