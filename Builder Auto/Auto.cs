using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Builder_Auto
{
  
    class Basement    {
        public Basement(){Console.WriteLine("Basement ready");}
    }
    class Floor
    {
        public Floor() { Console.WriteLine("Floor ready"); }
    }
    class Roof
    {
        public Roof() { Console.WriteLine("Roof ready"); }
    }
    class House    {
        ArrayList parts = new ArrayList();
        public void Add(object part)        {
            parts.Add(part);
        }
    }

    

    abstract class Builder    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House GetResult();
    }

    class ConcreteBuilder : Builder    {

        House house = new House();
        public override void BuildBasement(){house.Add(new Basement());}

        public override void BuildStorey(){house.Add(new Floor());}

        public override void BuildRoof(){house.Add(new Roof());}

        public override House GetResult()        {
            Console.WriteLine("House ready\n");
            return house;
        }
    }

}
