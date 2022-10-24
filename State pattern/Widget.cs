using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern
{
    enum HumanState
    {
        Sleep,
        Eat,
        Multiply
    }
    class Human    {
        public IHumanState State { get; set; }

        public Human(IHumanState ws)
        {
            State = ws;
        }

        public void Sleep()
        {
            State.Sleep(this);
        }
        public void Eat()
        {
            State.Eat(this);
        }
    }

   

   
    
   
}