using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern
{
    class HumanEatState : IHumanState
    {
        public void Sleep(Human water)
        {
            Console.WriteLine("Поели, можно поспать  ");
            water.State = new HumanSleepState();
        }

        public void Eat(Human water)
        {
            Console.WriteLine("Пожрать1");
        }
    }
}
