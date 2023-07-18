using Phone;
namespace Phone;

public class Phones
{
	public IBattery battery;
	public ICamera camera;
	public IDisplay display;
	public IMemory memory;
	public IProcessor processor;
	public ISpeaker speaker;
	
	public Phones (IBattery battery, ICamera camera, IDisplay display, IMemory memory, IProcessor processor, ISpeaker speaker)
	{
		this.battery = battery;
		this.camera = camera;
		this.display = display;
		this.memory = memory;
		this.processor = processor;
		this.speaker = speaker;
	}
}
