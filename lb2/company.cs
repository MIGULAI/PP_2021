using System;
using System.Collections.Generic;
using Linq;
using Worker;

namespace Company{

class Company<T> where T : class
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
        
    }
}

}