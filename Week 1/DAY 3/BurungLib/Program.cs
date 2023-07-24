class Program
{
	static void Main()
	{
		BurungMahal bbb = new BurungMahal();
		Burung aaa = bbb;
		
	  	aaa.kicau();
		bbb.kicau();
		aaa.sayap();
		bbb.sayap();
		aaa.corak(); 
		bbb.corak();
	  	
		bbb.Panjang = "Kicauannya Lumayan";
		Console.WriteLine(bbb.Panjang);
		bbb.panjang = "Kicauannya Panjang";
		Console.WriteLine(bbb.panjang);

		bool jnsBurung = bbb.setJenis("sultan");
		if(jnsBurung) 
		{
			Console.WriteLine("Jenisnya Mahal");
		}
		else 
		{
			Console.WriteLine("Jenisnya ndak Mahal");
		}
		
	}
}
