using System;
namespace DataStructure
{
    public class DNode<T> 
    {
        public T data;
        public DNode<T> prev;
        public DNode<T> next;
    
    public DNode()
    {
        data = default(T);
        prev = null;
        next = null;
    }
    public DNode(T _data)
    {
        data = _data;
        prev = null;
        next = null;
    }
    internal T Data
    {
        get {return data;}
        set {data = value;}
    }
    internal DNode<T> Prev
    {
        get {return prev;}
        set {prev = value;}
    }
    internal DNode<T> Next
    {
        get {return next;}
        set {next =value;}
    }
    }
}