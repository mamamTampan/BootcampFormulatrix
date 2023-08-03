using System;
using System.IO;

namespace ListItem
{
	public class File
	{
		private string path;
		private FileInfo info;
		private StreamWriter str;
		private string input;

		public File()
		{
			path = @"List Item.txt";
			info = new FileInfo(path);
			if (info.Exists)
			{
				str = info.AppendText();
			}
			else
			{
				str = info.CreateText();
			}
		}

		public void CreateFile()
		{
			str.Close();
			info.Create();
			Console.WriteLine("File has been created");
			Console.ReadKey();
		}

		public void CreateTextAuto()
		{
			str.WriteLine("My List Item");
			str.WriteLine("1. PC");
			str.WriteLine("2. Monitor");
			str.WriteLine("3. Mouse");
			str.WriteLine("4. Keyboard");
			str.Close();
			Console.WriteLine("File has been created with text");
			Console.ReadKey();
		}

		public void CreateTextManual()
		{
			Console.Write("Enter text: ");
			input = Console.ReadLine();
			str.Write(input);
			str.Close();
			Console.WriteLine("File has been created with text");
			Console.ReadKey();
		}

		public void DeleteFile()
		{
   			if (info.Exists)
			{
	   		str.Close();
			info.Delete();
			Console.WriteLine("File has been deleted");
			}
			else
			{
			Console.WriteLine("File doesn't exist");
			}
   	 		Console.ReadKey();
		}

	}
}
