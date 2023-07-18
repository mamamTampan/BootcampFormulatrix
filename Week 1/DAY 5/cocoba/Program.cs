class Program
{
	static void Main()
	{
		int a = 222;
		int b = 444;
		int c = a + b;

		Console.WriteLine(c);
		Console.WriteLine("");
/////////////////////////////////////////////////////////////////////
		int d = 5;
		int e = d;
		e = 2;
		
		Console.WriteLine(d);
		Console.WriteLine(e);	
		Console.WriteLine("");
/////////////////////////////////////////////////////////////////////
		double f = 0.2;
		double g = 0.3;
		if (f + g == 0.5)
		{
			Console.WriteLine("true");
		}
		else
		{
			Console.WriteLine("false");			
		}
		Console.WriteLine("");	
/////////////////////////////////////////////////////////////////////
		string[] Phone = {"Cinitnit", "Blekberi", "Aipon", "Androit"};
		Console.WriteLine(Phone[0]+", "+Phone[1]+", "+Phone[2]+", "+Phone[3]);
		Console.WriteLine("");
/////////////////////////////////////////////////////////////////////
////////////////GENERIC//////////////////////////////////////////////
		Handphone<int> intGenericClass = new Handphone<int>(10);
		int result = intGenericClass.HandphoneMethod(50000);
		Handphone<string> stringGenericClass = new Handphone<string>("Cinitnit");
		stringGenericClass.HandphoneMethod("Aipon");
		Console.WriteLine($"Harga: ${result}");

	}
}