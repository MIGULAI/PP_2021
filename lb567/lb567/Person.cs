using System;
using System.Collections.Generic;
using System.Text;

namespace lb567
{
    class Person
    {
        protected string Name { get; set; }
        protected string Sername { get; set; }
        protected string BDdate { get; set; }
        protected string Height { get; set; }

        protected Person()
        {

        }

        public Person(string name, string sername, string bddate , string height)
        {
            this.Name = name;
            this.Sername = sername;
            this.BDdate = bddate;
            this.Height = height;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetSername()
        {
            return this.Sername;
        }

        public string GetBDdate()
        {
            return this.BDdate;
        }

        public string GetHeight()
        {
            return this.Height;
        }

        protected void SetName(string _name)
        {
            this.Name = _name;
        }

        public Person ToPersone()
        {
            return null;
        }

    }
}
