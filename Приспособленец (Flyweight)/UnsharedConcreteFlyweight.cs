namespace Приспособленец__Flyweight_
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        int allState;
        public override void Operation(int extrinsicState)
        {
            allState = extrinsicState;
        }
    }
}
