namespace vegetableArray
{	
	class Program
	{
		static void Main()
		{
			
			Vegetable veg1 = new ("Kangkung");
			Vegetable veg2 = new ("Cabbage");
			Vegetable veg3 = new ("Wortel");
			Vegetable veg4 = new ("Terong");
			Vegetable veg5 = new ("Potato");
			
			Vegetable[] Vegetables = {veg1,veg2,veg3,veg4,veg5};
			Vegetable[] vegetables = new Vegetable[5];
			 vegetables[0] = veg1;
			 vegetables[1] = veg2;
			 vegetables[2] = veg3;
			 vegetables[3] = veg4;
			 vegetables[4] = veg5;
			 
			int[] price = new int[5];
			 price[0] = 2000;
			 price[1] = 50000;
			 price[2] = 3000;
			 price[3] = 9000;
			 price[4] = 20000;

			Console.WriteLine("\n Array nama sayuran :");
			for (int i = 0; i <= Vegetables.Length - 1; i++)
			{
				Console.WriteLine($"Sayur[{i+1}] = {Vegetables[i].Name}\t| Harga = {price[i]:c}\t|");
			}
			
			Console.WriteLine("\n Urutkan nama sayuran :");
			
			Array.Sort(Vegetables, (x, y) => x.Name.CompareTo(y.Name));
			Array.Sort(vegetables, SortingName);
			foreach (var veg in Vegetables)
			{
				
				Console.WriteLine($" - {veg.Name}");
			}
		}
		static int SortingName(Vegetable x, Vegetable y)
		{
			return x.Name.CompareTo(y.Name); 
		}
	
	}
	class Vegetable
	{
		public string Name { get; set; }
		public Vegetable(string name)
		{
			Name = name;
		}
	}
}