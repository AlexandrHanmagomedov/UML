using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Email_sender_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();
            facade.Operation1();


        //    Programmer programmer = new Programmer();
        //    Tester tester = new Tester();
        //    Marketolog marketolog = new Marketolog();

        //    List<ICommand> commands = new List<ICommand>
        //{
        //    new CodeCommand(programmer),
        //    new TestCommand(tester),
        //    new AdvertizeCommand(marketolog)
        //};
        //    Manager manager = new Manager();
        //    manager.SetCommand(new MacroCommand(commands));
        //    manager.StartProject();
        //    manager.StopProject();

        //    Console.Read();
        }
    }
}