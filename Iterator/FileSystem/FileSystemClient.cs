using IteratorDesignPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using File = IteratorDesignPattern.File;

public class FileSystemClient
{
    public static void Main(string[] args)
    {
        // Creating a file system structure
        IteratorDesignPattern.Directory root = new IteratorDesignPattern.Directory("Root");
        IteratorDesignPattern.Directory documents = new IteratorDesignPattern.Directory("Documents");
        File readme = new File("Readme.txt");
        File photo1 = new File("Photo1.jpg");
        File photo2 = new File("Photo2.jpg");

        root.AddComponent(documents);
        documents.AddComponent(readme);

        // Creating an iterator and navigating the file system
        IIterator<IFileSystemComponent> iterator = new FileSystemIterator(root.GetEnumerator());

        while (iterator.MoveNext())
        {
            Console.WriteLine($"Item: {iterator.Current.Name}");
        }
    }
}
