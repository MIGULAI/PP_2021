using System;

namespace Worker{
    class MonthWorker : MainWorker {
        public MonthWorker(string _name ,string _sername , int _salary){
            this.Name = _name;
            this.Sername = _sername;
            this.Salary = _salary;
        }
        public void Working(){
            Console.WriteLine("I have salary per hour");
        }
        public void SetSalary(int _salary){
            Salary = _salary;
        }
        
        public int GetSalary(){
            return Salary;
        }
    }
}