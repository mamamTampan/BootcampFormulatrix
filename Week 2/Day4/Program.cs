public struct Perhitungan
{
	public int X { get; }
	public int Y { get; }

	public Perhitungan(int x, int y)
	{
		X = x;
		Y = y;
	}

	public static Perhitungan operator +(Perhitungan p1, Perhitungan p2)
	{
		return new Perhitungan(p1.X + p2.X, p1.Y + p2.Y);
	}
}
class Program
{
	static void Main()
	{
		Perhitungan p1 = new Perhitungan (3,450);
		Perhitungan p2 = new Perhitungan (5,750);
		Perhitungan p3 = new Perhitungan (2,300);
		Perhitungan p4 = new Perhitungan (4,600);
		Perhitungan p5 = p1 + p2 + p3;
		Console.WriteLine($"- Item = {p1.X}, Total Harga = {p1.Y:C}");
		Console.WriteLine($"- Item = {p2.X}, Total Harga = {p2.Y:C}");
		Console.WriteLine($"- Item = {p3.X}, Total Harga = {p3.Y:C}");
		Console.WriteLine($"- Item = {p4.X}, Total Harga = {p4.Y:C}");
		Console.WriteLine($"Total Item = {p5.X}, Total Harga = {p5.Y:C}");
	
		Console.WriteLine("");
		Console.WriteLine("=============================================");
		Console.WriteLine("");
		
		List<Perhitungan> barang =  new List<Perhitungan> { p3, p1, p4, p2 };
		foreach (Perhitungan barangs in barang)
		{
			Console.WriteLine($"- Item = {barangs.X}, Total Harga = {barangs.Y:C}");				
		}
			Console.WriteLine($"Total Item = {p5.X}, Total Harga = {p5.Y:C}");
	}
}