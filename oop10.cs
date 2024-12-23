using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> stringQueue = new Queue<string>();
        stringQueue.Enqueue("Hello");
        stringQueue.Enqueue("World");
        stringQueue.Enqueue("Queue");

        Console.WriteLine("Queue<string>:");
        while (stringQueue.Count > 0)
        {
            Console.WriteLine($"Вилучено: {stringQueue.Dequeue()}");
        }


        Queue<double> doubleQueue = new Queue<double>();
        doubleQueue.Enqueue(12.5);
        doubleQueue.Enqueue(22.75);
        doubleQueue.Enqueue(42.25);

        Console.WriteLine("\nQueue<double>:");
        while (doubleQueue.Count > 0)
        {
            Console.WriteLine($"Вилучено: {doubleQueue.Dequeue()}");
        }


        Queue<int> intQueue = new Queue<int>();
        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);

        Console.WriteLine("\nQueue<int>:");
        while (intQueue.Count > 0)
        {
            Console.WriteLine($"Вилучено: {intQueue.Dequeue()}");
        }
    }
}