namespace Цепочка_Обязанностей__Chain_of_responsibility_
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
}
