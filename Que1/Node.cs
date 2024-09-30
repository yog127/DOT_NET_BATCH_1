using System;
namespace LinkList
{
    public class Node
    {
        public int data;
        public Node next;
    
    public Node()
    {
        data = -1;
        next = null;
    }
    public Node(int _data)
    {
        data = _data;
        next = null;
    }
    internal int Data
    {
        get {return data;}
        set {data = value;}
    }
    internal Node Next
    {
        get {return next;}
        set {next =value;}
    }
    }
}
