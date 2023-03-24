using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_1302210059
{
    internal class SimpleDataBase<T>
    {
        List<T> storedData { get; set; }
        List<DateTime> inputDates { get; set; }
        public SimpleDataBase()
        {
            storedData= new List<T>();
            inputDates= new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for(int i = 0; i< storedData.Count; i++)
            {
                Console.WriteLine("Data "+ (i+1)+" berisi "+ storedData.ElementAt(i) + " yang disimpan pada waktu " + inputDates.ElementAt(i));
            }
        }
    }
}
