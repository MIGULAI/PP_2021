using System;
using System.Collections.Generic;
using Company;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class ToWorker
    {
        public Company<MainWorker> ToCompany(List<BufWorker> a)
        {
            Company<MainWorker> company = new Company<MainWorker>();
            foreach (BufWorker i in a)
            {
                if (i.CType == "HourWorker")
                {
                    HourWorker n = new HourWorker(i);
                    company.AddWorker(n);
                }
                if(i.CType == "MonthWorker")
                {
                    MonthWorker n = new MonthWorker(i);
                    company.AddWorker(n);
                }
            }
            return company;
        }
  
    }
}
