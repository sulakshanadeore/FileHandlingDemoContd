using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemoContd
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Sulakshana\MphasisAugust\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();

            //File.Create(path+fname);
            fname = string.Concat(path, fname);

            //  File.Create(fname);
            //Console.WriteLine("file created successfully...");
            //Console.WriteLine("Enter your file contents");
            //string con=Console.ReadLine();
            //string[] contents = new string[2];
            //contents[0] = con;
            //File.WriteAllLines(fname, contents);
            //File.WriteAllText(fname, con);
            //File.AppendAllText(fname, con);
            //Console.WriteLine("file created successfully with contents...");
            // File.Copy(fname, "copiedFile.txt");
            //File.Move(fname, "MovedFile.txt");
            //Console.WriteLine("Successful....");
            //bool fileExists=File.Exists(fname);
            //Console.WriteLine("File Exists=  " + fileExists);
            //string contents=File.ReadAllText(fname);
            //Console.WriteLine(contents);
            //FileInfo fileInfo = new FileInfo(fname);
            //Console.WriteLine(fileInfo.FullName + "  Full Name");
            //    Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            //Console.WriteLine(fileInfo.CreationTime);
            Directory.CreateDirectory("MyDir");
            

            Console.ReadLine();
        }
    }
}
