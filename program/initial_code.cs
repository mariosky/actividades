using System.IO;
using System;
public class Producto
{
        public   code;
        public   desc;

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

