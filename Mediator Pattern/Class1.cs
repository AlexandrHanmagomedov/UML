//// Mediator pattern — Structural example
//using System;

//namespace DoFactory.GangOfFour.Mediator.Structural
//{

//    class MainApp
//    {

//        static void Main()
//        {
//            ConcreteMediator m = new ConcreteMediator();

//            ConcreteColleague1 c1 = new ConcreteColleague1(m);
//            ConcreteColleague2 c2 = new ConcreteColleague2(m);

//            m.Colleague1 = c1;
//            m.Colleague2 = c2;

//            c1.Send("How are you?");
//            c2.Send("Fine, thanks");

//            // Wait for user
//            Console.ReadKey();
//        }
//    }

//    abstract class Mediator
//    {
//        public abstract void Send(string message, Colleague colleague);
//    }

//    class ConcreteMediator : Mediator
//    {
//        public ConcreteColleague1 Colleague1 { private get; set; }

//        public ConcreteColleague2 Colleague2 { private get; set; }

//        public override void Send(string message, Colleague colleague)
//        {
//            if (colleague == Colleague1)
//            {
//                Colleague2.Notify(message);
//            }
//            else
//            {
//                Colleague1.Notify(message);
//            }
//        }
//    }

//    /// <summary>
//    /// The 'Colleague' abstract class
//    /// </summary>
//    abstract class Colleague
//    {
//        protected Mediator mediator;

//        // Constructor
//        public Colleague(Mediator mediator)
//        {
//            this.mediator = mediator;
//        }
//    }

//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    class ConcreteColleague1 : Colleague
//    {
//        // Constructor
//        public ConcreteColleague1(Mediator mediator)
//          : base(mediator)
//        {
//        }

//        public void Send(string message)
//        {
//            mediator.Send(message, this);
//        }

//        public void Notify(string message)
//        {
//            Console.WriteLine("Colleague1 gets message: " + message);
//        }
//    }

//    /// <summary>
//    /// A 'ConcreteColleague' class
//    /// </summary>
//    class ConcreteColleague2 : Colleague
//    {
//        // Constructor
//        public ConcreteColleague2(Mediator mediator)
//          : base(mediator)
//        {
//        }

//        public void Send(string message)
//        {
//            mediator.Send(message, this);
//        }

//        public void Notify(string message)
//        {
//            Console.WriteLine("Colleague2 gets message: " + message);
//        }
//    }
//}

////Output
////Colleague2 gets message: How are you?
////Colleague1 gets message: Fine, thanks