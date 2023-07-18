namespace Phone;

public class BestProcessor : IProcessor
{
	public string processor;
	public BestProcessor(string processor)
	{
		this.processor = processor;
	}
	public void	ProcessorWork()
	{
		Console.WriteLine("Processor Worked");
	}
}
