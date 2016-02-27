using System;
using System.Collections;

namespace DesignPatterns.Visitor
{
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elementA);
        public abstract void VisitElementB(ElementB elementB);
    }

    class ConcreteVisitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }

    class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }

    abstract class Element
    {
        public abstract void Accept(Visitor v);
    }

    class ElementA : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitElementA(this);
        }
        public void OperationA()
        {
            Console.WriteLine("OperationA");
        }
    }

    class ElementB : Element
    {
        public override void Accept(Visitor v)
        {
            v.VisitElementB(this);
        }
        public void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }

    class ObjectStructure
    {
        ArrayList elements = new ArrayList();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
                element.Accept(visitor);
        }
    }
}