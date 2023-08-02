using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
	public static Semaphore semaphore = new Semaphore(2,5); 

	static async Task Main()
	{
		Task[] tasks = new Task[10];
		for (int i = 1; i <= tasks.Length; i++)
		{
			int id = i;
			tasks[i-1] = Task.Run(() => Work(id));
		}

		await Task.WhenAll(tasks);
		Console.WriteLine("All Task Done.");
		Console.ReadLine();	
	}

	static void Work(int id)
	{
		Console.WriteLine($"Task {id} waiting semaphore ...");
		
		semaphore.WaitOne();

		try
		{
			Console.WriteLine($"Task {id} got semaphore.");
			
			Console.WriteLine($"Task {id} working ...");
			Thread.Sleep(9999);
		}
		finally
		{
			Console.WriteLine($"Task {id} realesed semaphore.");
			semaphore.Release();
		}
	}
}
