using System;

namespace Worker
{
    abstract class MainWorker{
        protected string Name {get ; set;}
        protected string Sername {get; set;}

        protected int Salary;

        public void setName(string _name){
            Name = _name;
        }

        public void setSername(string _sername){
            Sername = _sername;
        }

        public String GetName(){
            return Name;
        }
        public String GetSername(){
            return Sername;
        }
        public void Working(){}

        public void GetSalary(){}
        
        public void AdoutMe(){
            Console.WriteLine("My name is " + this.Name + " My sername is " + this.Sername + " and selary is " + this.Salary);
        }
    }
}