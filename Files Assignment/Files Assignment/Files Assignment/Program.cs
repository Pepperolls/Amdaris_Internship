using System;
using System.IO;
using System.Text;

namespace FileSystemAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo current = new DirectoryInfo(".");

            Console.WriteLine(current.FullName);


            string[] animals =
            {
                "Dog",
                "Cat",
                "Horse",
                "Fish"
            };

            string desktopFilePath1 = @"C:\Users\User\Desktop\animals1.txt";
            string desktopFilePath2 = @"C:\Users\User\Desktop\animals2.txt";

            if (!File.Exists(desktopFilePath1))
            {
                File.WriteAllLines(desktopFilePath1, animals);
                Console.WriteLine("File has been created");
            }
            else
            {
                File.Copy(desktopFilePath1, desktopFilePath2);
                File.Delete(desktopFilePath1);
                Console.WriteLine("File has been copied to another location and deleted");
            }
        }
    }
}
