using System;
using System.Collections.Generic;
using System.IO;
namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Задание 1

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Test ");
            DirectoryInfo directoryCreate = directoryInfo;
            List<DirectoryInfo> allDirectory = new List<DirectoryInfo>();

            for (int x = 1; x <= 50; x++)
            {
                allDirectory.Add(directoryInfo.CreateSubdirectory("Directory" + x));
            }

            foreach (var directory in allDirectory)
            {
                Console.WriteLine("FullName: " + directory.FullName);
                Console.WriteLine("CreationTime:" + directory.CreationTime);
                Console.WriteLine("Name: " + directory.Name);
                Console.WriteLine("Parent: " + directory.Parent + "\n");
            }

            for (int x = 1; x <= 50; x++)
            {
                Directory.Delete(@"D:\Test\Directory" + x);
            }

            #endregion Задание 1

            #region Задание 2

            FileInfo file = new FileInfo(@"D:\Test\Testing.txt");
            FileStream stream = file.Create();

            byte[] bytes = { 72, 79, 77, 69, 32, 87, 79, 82, 75};

            for(int x = 0; x < bytes.Length; x++ )
            {
                stream.WriteByte(bytes[x]);
            }
            stream.Position = 0;

            for (int x = 0; x < bytes.Length; x++)
            {
                Console.Write((char)stream.ReadByte());
            }
            stream.Close();
            File.Delete(@"D:\Test\Testing.txt");
            #endregion Задание 2 

            #region Задание 3

            StreamReader reader = File.OpenText(@"D:\Test\hwtest.txt");

            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if(line != null)
                {
                    Console.WriteLine(line);
                }
            }

            #endregion Задание 3

        }
    }
}
