namespace Состояние__State_
{
    class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
}
