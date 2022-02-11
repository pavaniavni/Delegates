using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    public delegate void RectangeDelete(double width, double height);
    internal class MultiCastDelegate
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area is :" + (width * height));
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Parameter is :" + (2 * (width + height)));
        }
        public void SetPerimeter(double width, double height)
        {
            Console.WriteLine("Parameter is :" + (2 * (width + height)));
        }
        //5
        static void Main3(string[] args)
        {
            MultiCastDelegate rect = new MultiCastDelegate();
            RectangeDelete rectange = new RectangeDelete(rect.GetArea);

            //multicast
            //you are pointing to two functions
            //Added two methods as a refernce
            rectange = rectange + rect.GetPerimeter;
            //calling delegate
            rectange.Invoke(12.56, 67.78);
            Console.WriteLine();
            //removed one  methods refernce from multicast delegate
            rectange = rectange + rect.SetPerimeter;
            rectange.Invoke(12.56, 67.78);
            Console.WriteLine();

        }
    }
}
