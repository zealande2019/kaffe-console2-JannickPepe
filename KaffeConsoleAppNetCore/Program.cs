using kaffe;
using System;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cortado kaffe1 = new Cortado();
            Latte kaffe2 = new Latte();
            SortKaffe kaffe3 = new SortKaffe();
            FlatWhite kaffe4 = new FlatWhite();

            //Ellers kan jeg også lave navne for kafferne også nedarve navnet på kafferne mht navnet i console.writeline

            Console.WriteLine("Cortado " + kaffe1.Pris() + "kr-; " + kaffe1.Styrke());
            Console.WriteLine("FlatWhite " + kaffe4.Pris() + "kr-;" + kaffe4.Styrke());
            Console.ReadLine();

        }
    }
}
