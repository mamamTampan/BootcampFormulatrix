using System;
namespace Phone
{
	class Program
	{
		static void Main()
		{
			BestBattery phoneBattery = new BestBattery("Battery Charging");
			BestCamera phoneCamera = new BestCamera("Camera On");
			BestDisplay phoneDisplay = new BestDisplay("Display On");
			BestMemory phoneMemory = new BestMemory("Memory Worked");
			BestProcessor phoneProcessor = new BestProcessor("Processor Worked");
			BestSpeaker phoneSpeaker = new BestSpeaker("Speaker On");

			Phones p = new(phoneBattery, phoneCamera, phoneDisplay, phoneMemory, phoneProcessor, phoneSpeaker);
			Console.WriteLine(p._battery);
			Console.WriteLine(p._camera);
			Console.WriteLine(p._display);
			Console.WriteLine(p._memory);
			Console.WriteLine(p._processor);
			Console.WriteLine(p._speaker);
		}
	}
}
