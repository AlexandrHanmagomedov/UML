using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_sender_Prototype
{
    public class Facade
    {
        Email_sender_Prototype.SubsystemA a = new Email_sender_Prototype.SubsystemA();


        public void Operation1()
        {
            Sender dev = new SpamSender("Спамер");
            Pismo house2 = dev.Create();
            Console.WriteLine(house2+"\n" + a.A1() + a.A2());
        }

    }
    internal class SubsystemA
    {
        internal string A1()
        {
            return "Система 1, Отправка рекламы тушенки \n";
        }
        internal string A2()
        {
            return "Система 1, Отправка котиков\n";
        }
    }
}
