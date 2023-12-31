﻿using SingletonPattern;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        var db = SingletonContainer.Instance;
        var db2 = SingletonContainer.Instance;
        var db3 = SingletonContainer.Instance;
        var db4 = SingletonContainer.Instance;

        Console.WriteLine(db.GetPopulation("London"));
    }

    /*
        Static is a keyword and Singleton is a design pattern
        Static classes can contain only static members
        Singleton is an object creational pattern with one instance of the class
        Singleton can implement interfaces, inherit from other classes and it aligns with the OOPS concepts
        Singleton object can be passed as a reference
        Singleton supports object disposal
        Singleton object is stored on heap
        Singleton objects can be cloned
    */
}