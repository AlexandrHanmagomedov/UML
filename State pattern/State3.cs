using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern
{
    class HumanMultiState : IHumanState
    {
        public void Sleep(Human water)
        {
            Console.WriteLine("Размножение после сна");
        }

        public void Eat(Human water)
        {
            Console.WriteLine("Размножение после большого сна");
            water.State = new HumanSleepState();
        }
    }
}
