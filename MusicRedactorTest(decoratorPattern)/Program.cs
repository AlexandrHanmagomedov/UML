using System;

class Program
{
    static void Main(string[] args)
    {
        Instrumeent inst = new Metall();
        inst = new Guitar(inst); 
        Console.WriteLine("Название: {0}", inst.Name);
        Console.WriteLine("Какая музыка: {0}", inst.Zvuk());
        Console.WriteLine();

        Instrumeent inst2 = new Metall();
        inst2 = new Baraban(inst2);
        Console.WriteLine("Название: {0}", inst2.Name);
        Console.WriteLine("Какая музыка: {0}", inst2.Zvuk());
        Console.WriteLine();

        Instrumeent inst3 = new PankRok();
        Instrumeent inst4 = new PankRok();
        inst3 = new Guitar(inst3);
        inst4 = new Baraban(inst3);
        Console.WriteLine("Название: {0}", inst3.Name);
        Console.WriteLine("Какая музыка: {0},{1}",inst4.Zvuk(), inst3.Zvuk());

    }
}

abstract class Instrumeent
{
    public Instrumeent(string n)
    {
        this.Name = n;
    }
    public string Name { get; protected set; }
    public abstract string Zvuk();
}

class Metall : Instrumeent
{
    public Metall() : base("Металл")
    { }
    public override string Zvuk()
    {
        return "ARrrghhh";
    }
}
class PankRok : Instrumeent
{
    public PankRok()
        : base("Панкрок")
    { }
    public override string Zvuk()
    {
        return "В заросшем парке....";
    }
}

abstract class Decorator : Instrumeent
{
    protected Instrumeent pizza;
    public Decorator(string n, Instrumeent pizza) : base(n)
    {
        this.pizza = pizza;
    }
}

class Guitar : Decorator
{
    public Guitar(Instrumeent p)
        : base(p.Name + ",c Гитарой", p)
    { }

    public override string Zvuk()
    {
        return "Гитарное соло";
    }
}

class Baraban : Decorator
{
    public Baraban(Instrumeent p)
        : base(p.Name + ", с Барабанами", p)
    { }

    public override string Zvuk()
    {
        return "Бум,тссс,бум,тссс";
    }
}