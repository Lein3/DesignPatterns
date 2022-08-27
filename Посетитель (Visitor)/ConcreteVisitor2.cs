namespace Посетитель__Visitor_
{
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
}
