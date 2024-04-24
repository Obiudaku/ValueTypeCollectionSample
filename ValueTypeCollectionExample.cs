using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct
{
    private List<T> items;

    public ValueTypeCollection()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }

        return items[index];
    }

    public List<T> GetSortedDescending()
    {
        return items.OrderByDescending(i => i).ToList();
    }
}
