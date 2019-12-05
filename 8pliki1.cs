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
            string path = @"C:\Users\Student\C#Files";

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Katalog Istnieje");
                }
                else
                {
                    Directory.CreateDirectory(@"C:\Users\Student\C#Files");
                    string textFilePath = @"C:\Users\Student\C#Files\testFile1.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("\nUtworzono katalog: {0}", Directory.GetCreationTime(path));

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("error: {0}", e.Message());
            }



            DirectoryInfo myDataDir = new DirectoryInfo(path);
            Console.WriteLine();
            FileInfo[] txtFiles = myDataDir.GetFiles(".txt", SearchOption.AllDirectories);
            Console.WriteLine("Ilość plików txt: {0}", txtFiles.Lenght);

            Console.WriteLine("Pliki teksowe");
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file);
            }



            //Czy chcesz usunąc dany katalog 1-tre 0-false, 1-sprawdzamy czy usuniety 0- nie usunales katalogu

            Console.WriteLine("Czy chcesz usunąc dany katalog? 1-true 0-false");
            int x = int.Parse(Console.ReadLine());
            
            switch (x)
            {
                case 1:
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                        Console.WriteLine("Usunales plik");
                    }
                    break;
                case 0:
                    Console.WriteLine("Nie usunales katalogu");
                    break;
            }



            Console.ReadKey();
        }
    }
}
