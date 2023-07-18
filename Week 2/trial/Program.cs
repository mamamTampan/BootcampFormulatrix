using System;
class Program
{
	static void Main()
	{
		int n;
		Console.WriteLine("=====Foobar=====");
		Console.Write("Masukan n = ");
		n = Convert.ToInt16(Console.ReadLine());
		
		foreach (int number in Masukan(0, n)) 
		{
			Console.Write(number+"  ");
		}
	}
}