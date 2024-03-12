using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul8
{    
    internal class Program
    {
        public class Info
        {
            public Info(string name, string volumeDisc, string freeVolume)
            {
                NameDisc = name;
                VolumeDisc = volumeDisc;
                FreeVolume = freeVolume;
            }
            public string NameDisc { get; }
            public string VolumeDisc { get; }
            public string FreeVolume { get; }

        }
        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();
        }

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
        /*
        public RootNum(string c)
        {
            Directory.GetDirectoryRoot(c);

        }*/
        static void Main(string[] args)
        {
            /*// получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }*/
            //Console.ReadKey();

            //RootNum("C:\\");
            GetQuanCatalogs();
            //String[] dir = Directory.GetDirectories(@"C:\\");
            //String[] fil = Directory.GetFiles(@"C:\\");
            //int a = (dir.Length + 1) + (fil.Length + 1);
            //Console.WriteLine(a);
            
            
            
            Console.ReadKey();
        }
        static void GetCatalogs()
        {
            string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                Console.WriteLine(dirs.Length);

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }
        static void GetQuanCatalogs()
        {
            string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                Console.WriteLine(dirs.Length);
                              

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога
                Console.WriteLine(files.Length);

            }
        }
    }
}
