using System;
using Worker;
using Company;
using System.Collections.Generic;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company<MainWorker> company = new Company<MainWorker>();
            HourWorker hourWorker = new HourWorker("Ivan" , "Vladimov" , 2000 );
            MonthWorker monthWorker = new MonthWorker("oleg" , "dhurnow" , 40000);
            company.AddWorker(monthWorker);
            company.AddWorker(hourWorker);
            company.AddWorker(new MonthWorker("kiril" , "yakupov" , 35000));
            
            company.SortWorkers();
            //company.ReturnLast().AdoutMe();
            //company.ReturnLastThree();
            company.SaveToFile(company);
            List < BufWorker > a = Company<MainWorker>.ReadFromFile();
            ToWorker b = new ToWorker();
            Company<MainWorker> company2 = b.ToCompany(a);
            Console.WriteLine(a.ToString());

        }
    }
}
