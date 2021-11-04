using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Paltaryuyan : texnika
    {
        public string modeli;

        public override string reng { get ; set; }

        public override void ozellikyaz()
        {
            Console.WriteLine("Paltaryuyanin ozellikleri");
            Console.WriteLine("Reng: {0}", reng);
            Console.WriteLine("Modeli: {0}", modeli);
        }
    }
}
