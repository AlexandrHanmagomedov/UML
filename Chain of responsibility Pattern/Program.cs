using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Receiver receiver = new Receiver(false, true, false);
            //Receiver receiver = new Receiver(false, false, true);
            Receiver receiver = new Receiver(true, false, false);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHadler;

            bankPaymentHandler.Handle(receiver);
        } 
    }
}

           




