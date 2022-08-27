namespace Цепочка_Обязанностей__Chain_of_responsibility_
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 1)
            {
                
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}
