using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактная_фабрика_авто{
    class Auto    {
        private Engine engine;
        private Movement movement;
        public Auto(AutoFactory factory)        {
            engine = factory.CreateEngine();
            movement = factory.CreateMovement();
        }
        public void Run(){
            movement.Move();
        }
        public void Work(){
            engine.Work();
        }
    }
    abstract class AutoFactory{
        public abstract Movement CreateMovement();
        public abstract Engine CreateEngine();
    }

    class ChinaFactory : AutoFactory{
        public override Movement CreateMovement(){
            return new ChinaMove();
        }
        public override Engine CreateEngine(){
            return new China();
        }
    }

    class JiguliFactory : AutoFactory{
        public override Movement CreateMovement(){
            return new JiguliMove();
        }
        public override Engine CreateEngine(){
            return new Jiguli();
        }
    }

}
