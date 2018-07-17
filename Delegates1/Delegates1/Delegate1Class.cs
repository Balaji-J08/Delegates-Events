using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Delegate1Class
    {
        public void add(int a, int b)
        {
            int c= a + b;
            Console.WriteLine("The Addition result is: "+c);

        }
        public void substract(int a, int b)
        {
            int d;
            if (a>b)
            {
                d= a - b;
            }
            else
            d = b - a;
           
            Console.WriteLine("The substraction result is: " + d);
        }



    }
}
