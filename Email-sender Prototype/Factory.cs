using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_sender_Prototype
{
    abstract class Pismo
    {

    }

    class SpamPismo : Pismo
    {
        public SpamPismo()
        {
            Console.WriteLine("Письмо создано");
        }
    }
    abstract class Sender
    {
        public string Name { get; set; }

        public Sender(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public Pismo Create();
    }

    class SpamSender : Sender
    {
        public SpamSender(string n) : base(n)
        { }

        public override Pismo Create()
        {
            return new SpamPismo();
        }
    }
}
