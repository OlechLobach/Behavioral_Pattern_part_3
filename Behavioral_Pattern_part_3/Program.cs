using VisitorPattern.Core;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new ElementCollection();
            elements.Attach(new ElementA());
            elements.Attach(new ElementB());

            var visitorA = new ConcreteVisitorA();
            var visitorB = new ConcreteVisitorB();

            elements.Accept(visitorA);
            elements.Accept(visitorB);

            Console.ReadKey();
        }
    }
}