using System;
using DataType;
class MainClass
{
    public static void Main(String[] args)
    {
    _INT  a= new _INT(10);
    _INT b= new _INT(5);
    Console.WriteLine(a.multi(a,b));
    Console.WriteLine(b.div(a,b));

      _FLOAT c = new _FLOAT(10);
      _FLOAT d = new _FLOAT(5);

    Console.WriteLine(c.multi(c,d));
    Console.WriteLine(d.div(c,d));
    }
    
}