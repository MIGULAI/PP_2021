using System;

namespace Worker
{
    abstract class MainWorker{
        private string Name {get ; set;}
        private string Sername {get; set;}

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
    }
}