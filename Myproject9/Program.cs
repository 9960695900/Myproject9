using System;

namespace Myproject9
{
    class AAA
    {
        public virtual void Add(int a,int b)
        {
            Console.WriteLine("Addition is="+(a+b));
        }
    }
    class BBB:AAA
    {
        public override void Add(int a,int b)
        {
            Console.WriteLine("Multipication="+(a*b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BBB b = new BBB();
            b.Add(10, 20);
        }
    }
}
