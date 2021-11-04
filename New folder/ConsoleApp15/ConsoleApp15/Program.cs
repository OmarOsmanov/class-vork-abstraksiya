using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Paltaryuyan paltaryuyan1 = new Paltaryuyan();
            qabyuyan qabyuyan1 = new qabyuyan();
            paltaryuyan1.reng = "qara";
            paltaryuyan1.modeli = "samsung smart home";
            qabyuyan1.reng = " ag";
            qabyuyan1.markasi = "Beko";
            paltaryuyan1.ozellikyaz();
            qabyuyan1.ozellikyaz();
        }
    }
}
