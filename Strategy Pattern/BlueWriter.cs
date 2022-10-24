using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class BlueWriter : IStrategy
    {
        public void Algorithm(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            // Выводим на консоль.
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
