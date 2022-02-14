using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator_Demo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("*************Arrithmatic Operation**************");
            Console.WriteLine("Enter value of A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B");
            b = Convert.ToInt32(Console.ReadLine());
       
           Console.WriteLine("Addition is:=" + (a+b));
           Console.WriteLine("Subtraction is:=" + (a -b));
           Console.WriteLine(" Divisionis:=" + (a / b));
           Console.WriteLine("Modulation is:=" + (a % b));
           Console.WriteLine("Multiplication is:=" + (a * b));

           Console.WriteLine("\n*************Arrithmatic Assignment**************");
          // int a = 10, b = 20, c = 0;
          int c = a + b;
           Console.WriteLine("c=a+b ==> "+c);
           c += a;
           Console.WriteLine("c+=a ==>"+c);
           c -= a;
           Console.WriteLine("c-=a ==>" + c);
           c *= a;
           Console.WriteLine("c*=a ==>" + c);
           c /= a;
           Console.WriteLine("c/=a ==>" + c);
           c %= a;
           Console.WriteLine("\n************Relational Operator***********");
           Console.WriteLine("a==b ==>" + (a==b));
           Console.WriteLine("a!=b ==>" +(a!=b));
           Console.WriteLine("a<b ==>" + (a<b));
           Console.WriteLine("a>b ==>" + (a>b));
           Console.WriteLine("a<=b ==>" +(a<=b));
           Console.WriteLine("a>=b ==>" +(a>=b));

           Console.WriteLine("*********Logical Operator**********");
            bool x = true, y=false;
            Console.WriteLine("x&&y==>"+(x&&y));
            Console.WriteLine("x||y==>" + (x || y));
            Console.WriteLine("!(x&&y)==>" + !(x && y));








     
            Console.ReadLine();
        }
    }
}
