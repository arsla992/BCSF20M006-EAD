using IteratorDesignPattern;
using System;
using System.Collections;
using System.Collections.Generic;


public class CollectionClient
{
    public static void Main(string[] args)
    {
        // Creating a collection
        Collection<int> collection = new Collection<int>();
        collection.AddItem(1);
        collection.AddItem(2);
        collection.AddItem(3);

        // Creating an iterator and iterating over the collection
        IIterator<int> iterator = collection.CreateIterator();

        while (iterator.MoveNext())
        {
            Console.WriteLine($"Item: {iterator.Current}");
        }
    }
}
