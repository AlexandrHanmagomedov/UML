using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern
{
    class HumanSleepState : IHumanState
    {
        public void Sleep(Human water)
        {
            Console.WriteLine("Ну еще чуть чуть поспим");
            water.State = new HumanMultiState();
        }

        public void Eat(Human water)
        {
            Console.WriteLine("Поспали, можно поесть");
            water.State = new HumanEatState();
        }
    }
}
