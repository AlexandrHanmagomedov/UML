using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedWriter redWriter = new RedWriter();
            redWriter.Algorithm("Red");
            Thread.Sleep(100);
            BlueWriter blueWriter = new BlueWriter();
            blueWriter.Algorithm("Blue");

            

          


           
        }
    }
}

