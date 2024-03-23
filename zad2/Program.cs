using System;
using System.Collections.Generic;

public sealed  class  PrintQueue {
    private static readonly  Lazy<PrintQueue> lazy = new Lazy<PrintQueue>(()=> new PrintQueue());
    public static PrintQueue Instance {get {return lazy.Value;}}
    private Queue<string> printJobs;
    private PrintQueue(){
        printJobs= new Queue<string>();

    }
    public void AddJob(string job){
        printJobs.Enqueue(job);
        Console.WriteLine($"Job add: {job}");
    }
    public void PrintAll(){
        while (printJobs.Count>0){
            var job = printJobs.Dequeue();
            Console.WriteLine($"Printing job: {job}");
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        var printQueue = PrintQueue.Instance;
        
        printQueue.AddJob("Zadanie 1");
        printQueue.AddJob("Zadanie 2");
        printQueue.AddJob("Zadanie 3");

        printQueue.PrintAll();

        Console.WriteLine("Wszystkie zadania wypisane");
    }
}
