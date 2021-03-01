using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem();

            //dortIslem.Topla(5, 6);
            //dortIslem.Topla(6, 9);

            int sayimizOut;
            DegistirOut(out sayimizOut);
            Console.WriteLine(sayimizOut);

            int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
            DegistirRef(ref sayimizRef);
            Console.WriteLine(sayimizRef);
        }
        static void DegistirRef(ref int sayiRef)
        {
            sayiRef = 1234;
        }

        static void DegistirOut(out int sayiOut)
        {
            sayiOut = 1234;
        }
    }
}
