using System;
using System.Collections.Generic;
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine(
                "Data " + (i + 1) +
                " berisi: " + storedData[i] +
                ", disimpan pada waktu: " + inputDates[i]
            );
        }
    }
}