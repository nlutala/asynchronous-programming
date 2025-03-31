namespace AsyncPracticeLib;

using System;
using System.Threading;
using System.Threading.Tasks;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Main Thread...");

        // Start a separate thread for a background task
        Thread backgroundThread = new Thread(BackgroundTask);
        backgroundThread.Start();

        // Execute an asynchronous operation
        Task.Run(() => ComputeAsync());

        Console.WriteLine("Main Thread is running...");
        Console.ReadLine();
    }

    static void BackgroundTask()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Background Task Iteration: {i}");
            Thread.Sleep(1000); // Simulate work
        }
        Console.WriteLine("Background Task Completed.");
    }

    static async Task ComputeAsync()
    {
        Console.WriteLine("Starting Async Computation...");
        await Task.Delay(2000); // Simulate async operation
        Console.WriteLine("Async Computation Complete.");
    }
}
