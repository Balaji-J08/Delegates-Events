using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{

    public delegate int GeneDelegate(int a, int b);
    class Delegate2Main
    {
        static void Main(string[] args)
        {

            Delegate2Class d = new Delegate2Class();
            GeneDelegate gd = d.add;
            gd += d.sub;
            int result=gd.Invoke(100, 200);
            Console.WriteLine(result);
            Console.ReadKey(); 

            /*using of Value returning return type: when ever we defined the return type other than the void then it returns onley the one value even though it has two methods
             -->here what heppens the return values are overridden so that the last methods value will be available  */

        }


    }
}
