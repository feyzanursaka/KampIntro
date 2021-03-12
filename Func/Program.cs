using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            //Console.WriteLine(Topla(2,3));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };           
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
