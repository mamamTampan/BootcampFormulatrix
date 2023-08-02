using System;
using System.Threading;
using System.Threading.Tasks;

namespace SyncAsyncExample
{
	class Program
	{
		static async Task Main()
		{
			DoSyncTask();
			await AsyncTask();
		}

		static void DoSyncTask()
		{
			Console.WriteLine("Thread 1 Started.");
			Thread.Sleep(100);
			Console.WriteLine("Thread 2 Started.");
			Thread.Sleep(1000);
			Console.WriteLine("All Thread Done.");
		}
		static async Task AsyncTask()
		{
			Console.WriteLine("Task 1 Started.");
			await Task.Delay(2000);
			Console.WriteLine("Task 2 Started.");
			await Task.Delay(200);
			Console.WriteLine("All Task Done.");
		}
	}
}
