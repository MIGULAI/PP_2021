using System;
using Worker;
using Company;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company<MainWorker> company = new Company<MainWorker>();
            HourWorker hourWorker = new HourWorker("Ivan" , "Vladimov" , 2000);
            company.AddWorker(hourWorker);
            company.ReturnLast().AdoutMe();
        }
    }
}
