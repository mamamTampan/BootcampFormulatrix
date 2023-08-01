using IPhone;
namespace Phone;

public class BestDisplay : IDisplay
{
	public string _display;
	public BestDisplay(string display)
	{
		this._display = display;
	}
	public void	DisplayOn()
	{
		Console.WriteLine("Display On");
	}
}
