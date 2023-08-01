using System.Collections.Generic;
using System.Linq;
class Program
{
	static void Main()
	{
		Dictionary<string,int> vegetable = new Dictionary<string,int>();
		vegetable.Add("Cabbage",50000);
		vegetable.Add("Kangkung",2000);
		vegetable.Add("Wortel",3000);
		vegetable.Add("Terong",9000);
		vegetable.Add("Potato",20000);
		
		foreach(var veg in vegetable)
		{
			Console.WriteLine($"Nama Sayur : {veg.Key}\t|  Harga : {veg.Value}");
		}
		
	}
}