using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Worker
{
    [Serializable()]
    abstract class MainWorker {

        protected string Name { get; set; }
        protected string Sername { get; set; }

        protected string type { get; set; }
        [JsonPropertyName("FName")]
        public string FName { get {
                return Name;
            }
            private set {
                Name = value;
            } }

        [JsonPropertyName("SName")]
        public string SName {get{
            return Sername;
        } 
        private set{
            Sername = value;
        }}
        [JsonPropertyName("CType")]
        public string CType{
            get{
                return type;
            }
            set{
                type = value;
            }
        }

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

        public MainWorker(string fName ,  string sName , string cType){
            FName = fName;
            SName = sName;
            CType = cType;
        }
    }
}