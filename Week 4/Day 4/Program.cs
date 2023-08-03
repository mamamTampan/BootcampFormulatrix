using System.IO;

namespace ListItem
{
	class Program
	{
		static void Main()
		{
			string path = @"ListItem.txt";
			FileInfo file = new(path);
			StreamWriter str = new(path);

			Console.WriteLine("Choose Menu");
			Console.WriteLine("1.Create File");
			Console.WriteLine("2.Create Text in File");
			Console.WriteLine("2.Create Custom Text in File");
			Console.WriteLine("4.Delete FIle");
			Console.Write("Choose : ");

			int n = Convert.ToInt32(Console.ReadLine());
			switch (n)
			{
				case 1:
					file.Create();
					Console.WriteLine("File has been created");
					Console.ReadKey();
					break;
				case 2:
					str.WriteLine("My List Item");
					str.WriteLine("1. PC");
					str.WriteLine("2. Monitor");
					str.WriteLine("3. Mouse");
					str.WriteLine("4. Keyboard");
					Console.WriteLine("File has been created with text");
					str.Close();
					break;
				case 3:
					string input = Console.ReadLine();
					str.Write(input);
					Console.WriteLine("File has been created with text");
					break;
				case 4:
					file.Delete();
					Console.WriteLine("File has been deleted");
					Console.ReadKey();
					break;
			}

		}
	}
}
