    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Pattern_factory
    {


    abstract class Creator
    {
        public string Name { get; set; }

        public Creator(string name )
        {
            this.Name = name;  
        }
        public abstract PuliaProduct FactoryMethod();
    }
 
    class MachineGunConcreteCreatorA : Creator
    {
        
        public MachineGunConcreteCreatorA(string name) : base(name) { }
        public override PuliaProduct FactoryMethod() {
            Console.WriteLine($"{this.Name}");
            return new MachineGunConcreteProductA(); }
    }
 
    class ShotcunConcreteCreatorB : Creator
    {
        public ShotcunConcreteCreatorB(string name) : base(name) { }
        public override PuliaProduct FactoryMethod() {
            Console.WriteLine($"{this.Name}");
            return new ShotcunConcreteProductB(); }
    }

        abstract class PuliaProduct
        { }

        class MachineGunConcreteProductA : PuliaProduct
        { 
            public MachineGunConcreteProductA()
        {
            Console.WriteLine("Пуля для автомата готова");
        }
        }

        class ShotcunConcreteProductB : PuliaProduct
        { 
            public ShotcunConcreteProductB()
        {
            Console.WriteLine("Картечь с солью готова");
        }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            Creator creator = new MachineGunConcreteCreatorA("Автомат");
            PuliaProduct pulia= creator.FactoryMethod();

            creator = new ShotcunConcreteCreatorB("Дробовик");
            PuliaProduct pulia1=creator.FactoryMethod();
            }
        }
    }
