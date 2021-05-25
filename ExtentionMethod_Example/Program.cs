using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int Amount = 25000;
            //Console.WriteLine(Amount.ToString("#,0 Rial"));
            //Console.WriteLine(MyClasss.ToRial(Amount));
            //Console.WriteLine(MyClasss.ToRial(741258));

            Console.WriteLine(13132.ToRial()); 
            Console.WriteLine(DateTime.Now.ToShamsi());
            Console.ReadKey();
        }
    }
}
