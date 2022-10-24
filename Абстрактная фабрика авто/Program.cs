using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактная_фабрика_авто
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto Lifan = new Auto(new ChinaFactory());
            Lifan.Work();
            Lifan.Run();

            Auto Vaz = new Auto(new JiguliFactory());
            Vaz.Work();
            Vaz.Run();

            Console.ReadLine();
        }
    }
}
