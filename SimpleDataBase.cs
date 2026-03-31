using System;
using System.Collections.Generic;
using System.Text;

namespace modul5_103082400005
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            storedData.Add(newData);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
            }
        }
    }
}
