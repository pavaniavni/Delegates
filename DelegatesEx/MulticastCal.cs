using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    public delegate void Delegates(int a, int b);
    internal class MulticastCal
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction : " + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication : " + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division : " + (a / b));
        }
        static void Main4(string[] args)
        {
            MulticastCal cal = new MulticastCal();
            Delegates c = new Delegates(cal.Add);

            c = c + cal.Sub+cal.Mul+cal.Div;
            c.Invoke(99, 89);
            Console.WriteLine();
            
            /*c = c + cal.Mul;
            c.Invoke(40, 50);
            Console.WriteLine();

            c=c+ cal.Div;
            c.Invoke(100, 20);
            Console.WriteLine();*/

        }

    }
}
