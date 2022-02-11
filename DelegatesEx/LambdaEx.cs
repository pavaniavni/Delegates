using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    internal class LambdaEx
    {
        public delegate string GreetDelegate(string name);
        //9
        static void Main(string[] args)
        {
            String Message = "HEY!";
            GreetDelegate gd = (name) =>
            {
                return "Hello " + name +" "+ Message;
            };
            Console.WriteLine(gd.Invoke("Pavani"));

        }
    }
}
