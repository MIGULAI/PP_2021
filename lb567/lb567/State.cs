using System;
using System.Collections.Generic;
using System.Text;

namespace lb567
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract string Handle1();

        public abstract string Handle2();
    }

    class ConcreteStateA : State
    {
        public override string Handle1()
        {
            
            this._context.TransitionTo(new ConcreteStateB());
            return "State was changed to 2";
        }

        public override string Handle2()
        {
            return "Criminal is free";
        }
    }

    class ConcreteStateB : State
    {
        public override string Handle1()
        {
            return "Criminal is not free";
        }

        public override string Handle2()
        {
           
            this._context.TransitionTo(new ConcreteStateA());
            return "State was changed to 1";
        }
    }

}
