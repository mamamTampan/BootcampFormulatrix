namespace Phone;

public class BestMemory : IMemory
{
	public string memory;
	public BestMemory(string memory)
	{
		this.memory = memory;
	}
	public void	MemoryWork()
	{
		Console.WriteLine("Memory Worked");
	}
}
