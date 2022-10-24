using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace State_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(new HumanSleepState());
            human.Eat();
            human.Sleep();
            human.Sleep();
            human.Eat();
            human.Eat();
            human.Eat();
            

            //Human water = new Human(new HumanSleepState());

            //water.Frost();
            //water.Frost();

            //Console.Read();


            //Context context = new Context(new StateA());
            //context.Request(); // Переход в состояние StateB
            //context.Request();  // Переход в состояние StateA
            //context.Request();

        }
    }
    class Context    {
        public State State { get; set; }
        public Context(State state){
            this.State = state;
        }
        public void Request(){
            this.State.Handle(this);
        }
    }
    abstract class State    {
        public abstract void Handle(Context context);
    }
    class StateA : State    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Поспали , можно поесть");
            context.State = new StateB();
        }
    }
    class StateB : State    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Поели , можно поспать");
            context.State = new StateA();
        }
    }

    
}
