namespace DesignPatterns;

using System;
using System.Collections.Generic;

// Step 1: Define the Component Interface
public interface IFileSystemItem
{
    void Display(string indent);
}

// Step 2: Create the Leaf Class
public class File : IFileSystemItem
{
    private string _name;

    public File(string name)
    {
        _name = name;
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}- File: {_name}");
    }
}

// Step 3: Create the Composite Class
public class Directory : IFileSystemItem
{
    private string _name;
    private List<IFileSystemItem> _items = new();

    public Directory(string name)
    {
        _name = name;
    }

    public void Add(IFileSystemItem item)
    {
        _items.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        _items.Remove(item);
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}+ Directory: {_name}");
        foreach (var item in _items)
        {
            item.Display(indent + "  ");
        }
    }
}

// Example Usage
public class Sample
{
    public static void Usage(string[] args)
    {
        // Create files
        IFileSystemItem file1 = new File("File1.txt");
        IFileSystemItem file2 = new File("File2.txt");
        IFileSystemItem file3 = new File("File3.txt");

        // Create directories and add files to them
        Directory directory1 = new Directory("Directory1");
        directory1.Add(file1);

        Directory directory2 = new Directory("Directory2");
        directory2.Add(file2);
        directory2.Add(file3);

        // Create the root directory and add subdirectories
        Directory rootDirectory = new Directory("RootDirectory");
        rootDirectory.Add(directory1);
        rootDirectory.Add(directory2);

        // Display the file system structure
        rootDirectory.Display("");
    }
}