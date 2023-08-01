using IPhone;
namespace Phone;

public class BestBattery : IBattery
{
	public string _battery;
	public BestBattery(string battery)
	{
		this._battery = battery;
	}
	public void	BatteryCharge()
	{
		Console.WriteLine("Battery Charging");
	}
}
