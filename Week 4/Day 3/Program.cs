using System.Threading.Tasks;

public class Program
{
	static Semaphore semaphore = new Semaphore(5, 5);

	static async Task Main()
	{
		Task task = Task.Run(() => DoWork());
		await task;
		Console.ReadLine();
	}

	static async Task DoWork( )
	{
		for (int i = 1; i <= 5; i++)
		{
		Console.WriteLine($"Task {i} mulai");
		semaphore.WaitOne();
		
		Console.WriteLine($"Task {i} berjalan");
		await Task.Delay(123);
		}
		Console.WriteLine($"Task selesai");
		semaphore.Release();
	}
}