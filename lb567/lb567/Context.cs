using System;
using System.Collections.Generic;
using System.Text;

namespace lb567
{
    class Context
    {
       
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }
        public State GetState()
        {
            return this._state;
        }
        public string Request1()
        {
            return this._state.Handle1();
        }

        public string Request2()
        {
            return this._state.Handle2();
        }
    }
}
