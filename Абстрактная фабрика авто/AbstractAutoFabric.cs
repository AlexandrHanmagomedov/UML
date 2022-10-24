using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактная_фабрика_авто
{
    abstract class Engine    {public abstract void Work();}
   
    abstract class Movement {public abstract void Move();}

    class China : Engine    {
        public override void Work(){Console.WriteLine("Едем на рыдване");}
    }

    class Jiguli : Engine    {
        public override void Work(){Console.WriteLine("Катаемся с кайфом");}
    }

    class ChinaMove : Movement    {
        public override void Move(){Console.WriteLine("Ползем");}
    }

    class JiguliMove : Movement    {
        public override void Move(){Console.WriteLine("Кайфуем");}
    }
}
