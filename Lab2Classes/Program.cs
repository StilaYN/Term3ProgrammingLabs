using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var goods = new Goods[6];
            goods[0] = new Printer();
            goods[1] = new Scanner();
            goods[2] = new Tablet();
            goods[3] = new Printer("Printer","#0001","some printer",1000,"Epson","BH-25","red",PrinterType.Laser,30);
            goods[4] = new Scanner("Scanner","#0002","some scanner",(decimal)1000.3221,"Epson","SC-3000","black",ScannerType.Planetary,1000);
            goods[5] = new Tablet("Tablet","#0007","some tablet",2000,"Samsung","GalaxyTab 3A","blue","gt-3000","vc-3000",4,128,13.5,60);
            foreach (Goods good in goods)
            {
                Console.WriteLine(good);
                good.Action();
            }

            Console.WriteLine(goods[2].Equals(goods[5]));
            Console.WriteLine(goods[2].GetHashCode());
        }
    }
}
