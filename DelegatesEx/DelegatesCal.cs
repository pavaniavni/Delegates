using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    
    internal class DelegatesCal
    {
        public delegate int Delegates(int a, int b);
        
        public static int Add(int x, int y)
        {
            return  (x + y);
        }
        public static int Sub(int x, int y)
        {
            return (x - y);
        }
        public static int Mul(int x, int y)
        {
            return (x * y);
        }
        public static int Divi(int x, int y)
        {
            return (x / y);
        }
    }
    class program 
    { 
        static void Main2(string[] args)
        {
             DelegatesCal.Delegates add = DelegatesCal.Add;
             DelegatesCal.Delegates sub = DelegatesCal.Sub;
             DelegatesCal.Delegates mul = DelegatesCal.Mul;
             DelegatesCal.Delegates div = DelegatesCal.Divi;
            


            int a = 20;
            int b = 10;
            int res;

            Console.WriteLine("1.Add ");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Exit");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    res = add(a, b);
                    
                    Console.WriteLine(res);
                    break;
                case 2:
                    res = sub(a, b);
                    Console.WriteLine(res);
                    break;
                case 3:
                    res = mul(a, b);
                    Console.WriteLine(res);
                    break;
                case 4:
                    res = div(a, b);
                    Console.WriteLine(res);
                    break;


                default:
                    Console.WriteLine("Impossible!");
                    break;
            }

            
            
        }
    }
}
