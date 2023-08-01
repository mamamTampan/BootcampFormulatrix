using System;
using System.Collections.Generic;

namespace FoobarApplication.Implement
{
	class Program
	{
		static void Main()
		{	
			
			IFoobar foo = new FoobarLib();
			Dictionary<int,string> fooLib = new Dictionary<int,string>();
			fooLib.Add(3,"Foo");
			fooLib.Add(5,"Bar");
			
			Console.WriteLine("================");
			Console.WriteLine("===== Menu =====");
			Console.WriteLine("== .1. Foobar ==");	
			Console.WriteLine("== .2. Exit   ==");
			Console.WriteLine("----------------");
			Console.Write(" Pilih menu : ");
			try
			{
				int n = Convert.ToInt16(Console.ReadLine());
				cekValidasi(n,foo);
				switch(n)
				{
					case 1 :
					{
						Console.Write("\nMasukan n = ");
						int jml = Convert.ToInt16(Console.ReadLine());
						string hasil = foo.foobar(jml,fooLib);
						Console.WriteLine(hasil);
						break;
					}
					case 2:
					{
						Console.Write(" Bye ...\n");
						break;
					}
					
				}
			}
			catch (FormatException)
			{
  				Console.WriteLine("Pilih 1 atau 2");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : "+ ex.Message);
			}
			
			static void cekValidasi(int n, IFoobar foo)
			{
				if (n != 1 && n!= 2)
				{
					throw new Exception("Silahkan pilih menu yang ada");
				}
			}
		}
	}
}