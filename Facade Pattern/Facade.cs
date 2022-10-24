using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class Facade
    {
        Facade_Pattern.SubsystemA a = new Facade_Pattern.SubsystemA();
        Facade_Pattern.SubsystemB b = new Facade_Pattern.SubsystemB();
        Facade_Pattern.SubsystemC c = new Facade_Pattern.SubsystemC();

        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
            a.A1() +
            a.A2() +
            b.B1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
            b.B1() +
            c.C1());
        }
        public void Operation3()
        {
            Console.WriteLine("Operation 3\n" +
            b.B1() +a.A1() + c.C1());
        }
    }
}
