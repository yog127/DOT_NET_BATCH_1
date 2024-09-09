﻿using System;

namespace DataStructure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List myList = new List();
            myList.InsertAtBegin(10);
            myList.InsertAtBegin(20);

            myList.PrintList();

            myList.InsertAtEnd(30);
            myList.InsertAtEnd(40);

            myList.PrintList();

            myList.InsertAfter(50,30);
            myList.InsertAfter(60,20);

            myList.PrintList();

            // myList.RemoveAtBegin();
            // myList.RemoveAtEnd();
            myList.RemoveAtPos(2);

            myList.PrintList();

            myList.FindElement(10);
            myList.FindLength();

            myList.PrintList();
        }
    }
}