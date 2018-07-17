using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class MultiCastingClass1
    {
       public  void add(int a,int b)
        {
            int c;

            c = a + b;
            Console.WriteLine("The added value is as follows: "+c);

        }
        public void sub(int a, int b)
        {

            int d;
           d = a - b;
            Console.WriteLine("The Subtracted value is as follows: " + d);

        }

        public void multiply(int a,int b)
        {
            int e;
            e = a * b;
            Console.WriteLine("The Multiplyed value is as follows: " + e);


        }

        public void Division(int a, int b)
        {
            int f;
            f = a / b;
            Console.WriteLine("The Multiplyed value is as follows: " + f);

        }




    }
}
