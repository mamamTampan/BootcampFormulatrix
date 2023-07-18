using System;

public static IFoobar<int> Masukan(int start, int end)
	{
		for (int i = start; i <= end; i++)
		{
			if ((i > 0)&&((i % 3 == 0)&&((i % 5 == 0))))
			{
				Console.Write("foobar  ");
			}
			else if ((i > 0)&&(i % 3 == 0))
			{
				Console.Write("foo  ");
			}
			else if ((i > 0)&&(i % 5 == 0))
			{
				Console.Write("bar  ");
			}
			else
			{
				yield return i ;
				
			}
		}
	}