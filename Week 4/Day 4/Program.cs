using System;
using System.IO;

namespace ListItem
{
    class Program
    {
        static void Main()
        {
            File file = new File();
            
            Console.WriteLine("Choose Menu");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Create Text in File");
            Console.WriteLine("3. Create Custom Text in File");
            Console.WriteLine("4. Delete File");
            Console.Write("Choose : ");

            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    file.CreateFile();
                    break;
                case 2:
                    file.CreateTextAuto();
                    break;
                case 3:
                    file.CreateTextManual();
                    break;
                case 4:
                    file.DeleteFile();
                    break;
            }
        }
    }
}
