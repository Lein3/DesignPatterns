namespace Заместитель__Прокси_
{
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
                realSubject = new RealSubject();
            realSubject.Request();
        }
    }
}
