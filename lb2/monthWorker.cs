using System;

namespace Worker{
    class MonthWorker : MainWorker {
        private BufWorker i;

        public MonthWorker(string _name ,string _sername , int _salary){
            this.Name = _name;
            this.Sername = _sername;
            this.Salary = _salary;
            this.type = "MonthWorker";
        }

        public MonthWorker(BufWorker i)
        {
            this.Name = i.FName;
            this.Sername = i.SName;
            this.type = "MonthWorker";
        }

        public void Working(){
            Console.WriteLine("I have salary per hour");
        }
        public void SetSalary(int _salary){
            Salary = _salary;
        }
        
        public override int GetSalary(){
            return Salary;
        }
    }
}