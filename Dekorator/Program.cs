// Definicja interfejsu IComponent, który będzie dekorowany
public interface IComponent
{
    string Operation();
}

// Definicja klasy ConcreteComponent, która implementuje interfejs IComponent
public class ConcreteComponent : IComponent
{
    public string Operation()
    {
        return "ConcreteComponent";
    }
}

// Definicja klasy Decorator, która dziedziczy po interfejsie IComponent i zawiera referencję do obiektu IComponent
public abstract class Decorator : IComponent
{
    protected IComponent component;

    public Decorator(IComponent component)
    {
        this.component = component;
    }

    public virtual string Operation()
    {
        return component.Operation();
    }
}

// Definicja klasy ConcreteDecoratorA, która dziedziczy po klasie Decorator i dodaje dodatkowe zachowanie do Operation
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component)
    {
    }

    public override string Operation()
    {
        string result = base.Operation();
        result += " + ConcreteDecoratorA";
        return result;
    }
}

// Definicja klasy ConcreteDecoratorB, która dziedziczy po klasie Decorator i dodaje dodatkowe zachowanie do Operation
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component)
    {
    }

    public override string Operation()
    {
        string result = base.Operation();
        result += " + ConcreteDecoratorB";
        return result;
    }
}
namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Przykładowe użycie wzorca dekorator
            IComponent component = new ConcreteComponent();
            Console.WriteLine(component.Operation()); // wyświetli "ConcreteComponent"

            IComponent decoratorA = new ConcreteDecoratorA(component);
            Console.WriteLine(decoratorA.Operation()); // wyświetli "ConcreteComponent + ConcreteDecoratorA"

            IComponent decoratorB = new ConcreteDecoratorB(decoratorA);
            Console.WriteLine(decoratorB.Operation()); // wyświetli "ConcreteComponent + ConcreteDecoratorA + ConcreteDecoratorB"

            Console.ReadLine();
        }
    }
}


