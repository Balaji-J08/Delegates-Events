using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void MathDelegate(int a, int b);
    class Delegate1Main
    {
        static void Main(string[] args)
        {
            Delegate1Class d = new Delegate1Class();
            // MathDelegate md = new MathDelegate(d.add);
            //md(100,200);//Delgate:one method get executed and it holds the reference of one method 
            MathDelegate md =d.add;
            md += d.substract;//multicasting Delegate:making delegate to hold the reference of more than one method at a time here md holds both the methods
            md(1000, 2000);
            
            Console.ReadKey();
                 
        }
    }
}
