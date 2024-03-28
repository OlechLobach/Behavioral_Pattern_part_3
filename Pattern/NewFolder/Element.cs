using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Core
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class ElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("Element A operation");
        }
    }

    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("Element B operation");
        }
    }

    public class ElementCollection
    {
        private readonly List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }

    public interface IVisitor
    {
        void VisitElementA(ElementA element);
        void VisitElementB(ElementB element);
    }

    public class ConcreteVisitorA : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            Console.WriteLine("Visitor A visits Element A");
            element.OperationA();
        }

        public void VisitElementB(ElementB element)
        {
            Console.WriteLine("Visitor A visits Element B");
            element.OperationB();
        }
    }

    public class ConcreteVisitorB : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            Console.WriteLine("Visitor B visits Element A");
            element.OperationA();
        }

        public void VisitElementB(ElementB element)
        {
            Console.WriteLine("Visitor B visits Element B");
            element.OperationB();
        }
    }
}