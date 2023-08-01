using System;
using System.Collections.Generic;

namespace FoobarApplication.Implement
{
	public class FoobarLib : IFoobar
	{
		public string foobar(int jml, Dictionary<int, string> fooLib)
		{
			string hasil="";
			for (int i = 0; i <= jml; i ++)
			{
				bool habis = false;
				foreach (var lib in fooLib)
				{
					if (i > 0 && i % lib.Key == 0)
					{
						hasil += lib.Value+" ";
						habis = true;
					}
				}
				    if (!habis)
					{
						hasil += i.ToString()+" ";
					}
			}
			return hasil+".";
		}
	}
}