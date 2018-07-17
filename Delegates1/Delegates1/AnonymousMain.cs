using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate String AnoDelegate(String msg);
    class AnonymousMain
    {
        public string print(String msg)
        {
            return "Hello"+ msg +"Good morning";   
        }

        static void Main(string[] args)
        {
           // AnonymousMain a = new AnonymousMain();
            

           // AnoDelegate AD = new AnoDelegate(a.print);
            AnoDelegate AD = delegate (String msg)              //here Anonymous method is implemented 
            {
                return "Hello " + msg + " Good morning";
            };

            String s =AD.Invoke("Guyss");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        

    }
}
