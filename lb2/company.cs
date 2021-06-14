using System;
using System.Collections.Generic;
using System.Linq;
using Worker;
using System.Text.Json;
using System.IO;
using System.Text.RegularExpressions;


namespace Company{
 [Serializable()]
class Company<T> where T : MainWorker
{
    public List<T> workers = new List<T>();

   
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
    public void SaveToFile(Company<T> a){
        string json;
        json = JsonSerializer.Serialize(workers);
        Console.WriteLine ( "1" + json);
        using (FileStream fstream = new FileStream($"note.txt", FileMode.Create))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(json);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
        
    }
    }
    public static List< BufWorker> ReadFromFile(){
            List<BufWorker> s = new List<BufWorker>();
        using (StreamReader sr = new StreamReader("note.txt", System.Text.Encoding.Default))
        {
        string json;
        

        while ((json = sr.ReadLine()) != null)
        {
            Console.WriteLine("2" + json);
            List<BufWorker> a = JsonSerializer.Deserialize<List<BufWorker>>(json);
            return a;
        }
        
        return null;
        }
}
}
}