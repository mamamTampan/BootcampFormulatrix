using IPhone;
namespace Phone;

public class BestProcessor : IProcessor
{
	public string _processor;
	public BestProcessor(string processor)
	{
		this._processor = processor;
	}
	public void	ProcessorWork()
	{
		Console.WriteLine("Processor Worked");
	}
}
