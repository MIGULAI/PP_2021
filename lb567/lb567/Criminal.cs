using System;
using System.Collections.Generic;
using System.Text;

namespace lb567
{
    class Criminal : Person
    {
        private string Reckoning {get; set;}
        private Wanted Status { get; set; }

        private Context _context { get; set; }
        public Criminal(Person person , Context context)
        {
            this.Name = person.GetName();
            this.Sername = person.GetName();
            this.BDdate = person.GetBDdate();
            this.Height = person.GetHeight();
            this._context = context;
        }

        public void SetReconing(string reckoning)
        {
            this.Reckoning = reckoning;
        }

        public void SetStatus(Wanted wanted)
        {
            this.Status = wanted;
        }

        public Context GetGontext()
        {
            return this._context;
        }

        public Wanted GetStatus()
        {
            return this.Status;
        }

        public string GetReckoning()
        {
            return this.Reckoning;
        }

        public String GetCriminalInfo()
        {
            string Status = "";
            if ("lb567.ConcreteStateA" == this._context.GetState().ToString())
            {
                Status = this._context.Request2();
            }
            Console.WriteLine(this._context.GetState()) ;
            return "Name is : " + this.Name + "\n" + "Sername is : " + this.Sername + "\n" + "BDay is : " + this.BDdate + " \n" + "Wanted status is : " + this.Status + "\n" + Status;
        }


        public new Person ToPersone()
        {
            return new Person(Name, Sername, BDdate, Height);
        }
    }
}
