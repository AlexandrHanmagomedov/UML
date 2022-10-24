using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConcreteBuilder builder = new ConcreteBuilder();

            builder.BuildBasement();

            builder.BuildStorey();

            builder.BuildRoof();

            builder.GetResult();
            
            
        }
    }
}
