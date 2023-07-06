using Phone;
class Program
{
	static void Main()
	{
		BestBattery phoneBattery = new BestBattery("Battery Charging");
		BestCamera phoneCamera = new BestCamera("");
		BestDisplay phoneDisplay = new BestDisplay("");
		BestMemory phoneMemory = new BestMemory("");
		BestProcessor phoneProcessor = new BestProcessor("");
		BestSpeaker phoneSpeaker = new BestSpeaker("");
		
		Phones phones = new(phoneBattery,phoneCamera,phoneDisplay,phoneMemory,phoneProcessor,phoneSpeaker);
		
	}
}