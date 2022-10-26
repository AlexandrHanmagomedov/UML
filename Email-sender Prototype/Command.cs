using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_sender_Prototype
{
    interface IObservable
    {
        void AddObserver(IObserver o);

    }
    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
    }

    interface IObserver
    {
        void Update();
    }
    class ConcreteObserver : IObserver
    {
        public void Update()
        {

        }
    }
    public class Emails
    {
        List<string> adr;

        Emails()
        {
            adr = new List<string>();
        }
    }
}
