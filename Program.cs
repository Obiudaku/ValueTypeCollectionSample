using System;

namespace ValueTypeCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeCollection<int> intCollection = new ValueTypeCollection<int>();
            intCollection.AddItem(5);
            intCollection.AddItem(3);
            intCollection.AddItem(8);

            Console.WriteLine("Items:");
            foreach (var item in intCollection.GetSortedDescending())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Item at index 1: " + intCollection.GetItem(1));
        }
    }
}
