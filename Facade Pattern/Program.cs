using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Operation1();
            facade.Operation2();
            facade.Operation3();

        }
    }
}