using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class qabyuyan : texnika
    {
        public string markasi;

        public override string reng { get; set; }

        public override void ozellikyaz()
        {
            Console.WriteLine("Qabyuyanin ozellikleri");
            Console.WriteLine("Reng: {0}", reng);
            Console.WriteLine("Markasi: {0}", markasi);
        }
    }
}
