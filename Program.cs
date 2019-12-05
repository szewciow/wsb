using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace _8pliki
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            Console.WriteLine(wsbDir.FullName);

            //DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student\\Desktop");
            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop"); //studentDir przechowuje informacje o tej konkretnej lokalizacji 
            Console.WriteLine(studentDir.FullName);//nazwa folderu
            Console.WriteLine(studentDir.Name);//folder nadrzędny
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");
            string[] customers =
            {
                "Agnieszka Nowak",
                "Anna Nowak",
                "Tomasz Kowalski"
            };
            Directory.CreateDirectory(@"C:\Users\Student\C#Files");
            string path = @"C:\Users\Student\C#Files";
            string textFilePath = @"C:\Users\Student\C#Files\testFile1.txt";
            File.WriteAllLines(textFilePath, customers);





            Console.ReadKey();
        }
    }
}
