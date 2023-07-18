﻿using System;
public struct Hitung
{
	public int X { get; }

	public Hitung(int x , int date)
	{
		X = x;
	}

	public static Hitung operator +(Hitung d1, Hitung d2)
	{
		return new Hitung(d1.X + d2.X);
	}
}
class Program
{
	static void Main()
	{
		Hitung d1 = new Hitung (3);
		Hitung d2 = new Hitung (4);
		
		DateTimeOffset date = DateTime.Now;
		Console.WriteLine("Waktu: {0}", date);
		Console.WriteLine("==================================");
		

		List<Hitung> date1 =  new List<Hitung> { d1, d2 };
		foreach (Hitung date2 in date1)
		{
		
			Console.WriteLine($"Booking jam {date2.X}");
			Console.WriteLine(" jam lagi");				
		}
			
		
	}
}