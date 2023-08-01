using IPhone;
namespace Phone;

public class BestMemory : IMemory
{
	public string _memory;
	public BestMemory(string memory)
	{
		this._memory = memory;
	}
	public void	MemoryWork()
	{
		Console.WriteLine("Memory Worked");
	}
}
