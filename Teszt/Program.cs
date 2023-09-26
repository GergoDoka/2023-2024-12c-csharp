using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Példányosítom az osztályt
            KorClass kor1 = new KorClass(3.0);
            kor1.setKerulet(kor1.getSugar());
            kor1.setTerulet();

            Console.WriteLine("A {0:0.0000} sugarú kör Kerülete: {1:0.0000}. Területe: {2:0.0000}",
                kor1.getSugar(),
                kor1.getKerulet(),
                kor1.getTerulet());

            Console.ReadKey();
        }
    }
}
