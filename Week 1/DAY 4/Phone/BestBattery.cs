namespace Phone;

public class BestBattery : IBattery
{
	public string battery;
	public BestBattery(string battery)
	{
		this.battery = battery;
	}
	public void	BatteryCharge()
	{
		Console.WriteLine("Battery Charging");
	}
}
