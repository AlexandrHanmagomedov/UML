using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    // класс заказчика
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }
}
