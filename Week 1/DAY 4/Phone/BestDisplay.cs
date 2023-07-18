namespace Phone;

public class BestDisplay : IDisplay
{
	public string display;
	public BestDisplay(string display)
	{
		this.display = display;
	}
	public void	DisplayOn()
	{
		Console.WriteLine("Display On");
	}
}
