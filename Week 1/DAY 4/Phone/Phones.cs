using IPhone;
namespace Phone;

public class Phones
{
	public IBattery _battery;
	public ICamera _camera;
	public IDisplay _display;
	public IMemory _memory;
	public IProcessor _processor;
	public ISpeaker _speaker;
	
	public Phones (IBattery battery, ICamera camera, IDisplay display, IMemory memory, IProcessor processor, ISpeaker speaker)
	{
		this._battery = battery;
		this._camera = camera;
		this._display = display;
		this._memory = memory;
		this._processor = processor;
		this._speaker = speaker;
	}
}
