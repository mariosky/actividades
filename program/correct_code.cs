using System.IO;
using System;
public class Producto
{
        public int  code;
        public string  desc;

        public Producto(int c, string d)
        {
        code=c;
        desc=d;
        }

        public void Print()
        {
        Console.WriteLine("Producto {0}: {1}", code,desc);
        }

}


