﻿namespace Состояние__State_
{
    class Context
    {
        public State State { get; set; }
        public Context(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
