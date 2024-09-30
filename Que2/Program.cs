using System;
namespace DataStructure
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            DoublyCircularLinkedList<int> dcl =new DoublyCircularLinkedList<int>();
            dcl.InsertBegin(20);
            dcl.InsertEnd(10);
            dcl.Find(10);
            dcl.Reverse();
            dcl.LinkListToArray();
            dcl.PrintList();
        }
    }
}