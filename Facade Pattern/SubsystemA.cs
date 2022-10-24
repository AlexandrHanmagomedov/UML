using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class SubsystemA
    {
        internal string A1()
        {
            return "Система 1, Метод 1\n";
        }
        internal string A2()
        {
            return "Система 1, Метод 2\n";
        }
    }
}
