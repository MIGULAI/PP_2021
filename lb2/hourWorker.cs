using System;

namespace Worker{
    class HourWorker : MainWorker {
        public void Working(){
            Console.WriteLine("I have salary per hour");
        }
        public void SetSalary(int _salary){
            Salary = _salary;
        }
        
        public int GetMonthSalary(int _hourNumber){
            return Salary*_hourNumber;
        }

        public int GetHourSalary{
            
        }
    }
}