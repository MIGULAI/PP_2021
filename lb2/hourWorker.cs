using System;

namespace Worker{
    class HourWorker : MainWorker {
        public HourWorker(string _name ,string _sername, int _salary ){
            this.Name = _name;
            this.Sername = _sername;
            this.Salary = _salary;
            this.type = "HourWorker";
        }

        public HourWorker(BufWorker a)
        {
            this.Name = a.FName;
            this.Sername = a.SName;
            this.type = "HourWorker";
        }
        public void Working(){
            Console.WriteLine("I have salary per hour");
        }
        public void SetSalary(int _salary){
            Salary = _salary;
        }
        
        public int GetDaySalary(){
            return Salary;
        }

        public override int GetSalary(){
            return Salary*5*4*8;
        }
    }
}