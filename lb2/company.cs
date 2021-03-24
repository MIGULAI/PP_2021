using System;
using System.Collections.Generic;
using System.Linq;
using Worker;

namespace Company{

class Company<T> where T : MainWorker
{
    private List<T> workers = new List<T>();

    public void AddWorker(T _worker){
        workers.Add(_worker);
    }

    public T ReturnLast(){
        int i = workers.Count;
        return workers[--i];
    }
    public void SortWorkers(){
        var sorted = from w in workers
                     orderby w.GetSalary() descending
                     select w;
        workers = sorted.ToList();
    }
    public void ReturnLastThree(){
        
        for(int i = 3; i > 0 ; i--){
            workers[workers.Count - i].AdoutMe();
        }
    }
}

}