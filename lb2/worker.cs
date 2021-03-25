using System;

namespace Worker
{
    [Serializable()]
    abstract class MainWorker{
        
        protected string Name {get ; set;}
        protected string Sername {get; set;}

        public string SName {get{
            return Name;
        } 
        private set{
            Name = value;
        }}

        public MainWorker(){

        }

        public MainWorker(string _name){
            SName = _name;
        }

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

        public virtual int GetSalary(){
            return Salary;
        }
        
        public void AdoutMe(){
            Console.WriteLine("My name is " + this.Name + " My sername is " + Sername + " and selary is " + this.GetSalary());
        }
    }
}