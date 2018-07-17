using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void GiantDelegate(int a, int b);
    class MulticastingMain1
    {
        static void Main(string[] args)
        {
            MultiCastingClass1 mc = new MultiCastingClass1();
            GiantDelegate Gd = new GiantDelegate(mc.add);//or GiantDelegate Gd =mc.add;
            Gd += mc.sub;
            Console.WriteLine();
            Gd += mc.multiply;
            Console.WriteLine();
            Gd += mc.Division;
            Console.WriteLine();
            Gd.Invoke(100, 200);
            Console.ReadKey();






        }



    }
}
