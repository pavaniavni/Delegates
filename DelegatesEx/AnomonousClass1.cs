using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    public class AnonymousMethods
    {

        public delegate string GreetDelegate(string name);
        //public static string Greet(string name)
        //{
        //    return "Hello " + name;
        //}
        //8
        static void Main8(string[] args)
        {
            String Message = "HEY !";
            //GreetDelegate gd = new GreetDelegate(AnonymousMethods.Greet);
            GreetDelegate gd = delegate (string name)
            {
                return "Hello " + name +" "+ Message;
            };
            Console.WriteLine(gd.Invoke("Pavani avni"));
        }
    }
}
