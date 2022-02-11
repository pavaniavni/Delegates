using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    internal class OutMultiCast1
    {
        public static void MethodOne(out int number)
        {
            number = 1;
        }
        public static void MethodTwo(out int number)
        {
            number = 2;
        }

        public delegate void SampleDelegate(out int Integer);
        //6
        static void Main5(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;
            int ValuefromOuput = -1;
            del(out ValuefromOuput);
            Console.WriteLine(ValuefromOuput);
        }
    }
}
