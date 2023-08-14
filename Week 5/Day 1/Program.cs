using System.Runtime.InteropServices;

namespace CobaDay1;
class Program
{


	static void Main()
	{
		Console.Clear();
		List<string> names = new List<string>{"Adam","Idris","Nuh","Hud","Sholeh","Ibrahim","Luth","Ismail"};
		var order = names.Where(n => n.Length >= 2)
						.Order()
						.ToList();
		foreach (var item in order)
		{
			Console.Write($"  {item}");
		}
		Console.WriteLine();
		
		string[] add= {"Ishaq","Yaqub","Yusuf","Ayyub"};
		order.AddRange(add);
		var adds = order.Join
						.Where(n => n.Length <= 10)
						.ToList();
		foreach (var addd in adds)
		{
			Console.Write($"  {addd}");
		}
		
		
		//names.AddRange(add);
	}
}
