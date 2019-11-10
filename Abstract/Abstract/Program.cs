using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Temp\PROC#.txt";
            FileInfo fi = new FileInfo(fileName);
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Author: Andrew Troelsen");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("With .NET and .NET Core");
                    sw.WriteLine("Done! ");
                }
            using (StreamWriter writer = new StreamWriter("New file created"))
            {
                writer.Write("Author: Andrew Troelsen");
                writer.WriteLine("**********");
                writer.WriteLine("With .NET and .NET Core");
            }
            // Create a new file     
            //using (FileStream fs = File.Create(fileName))
            //{
            //    // Add some text to file    
            //    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
            //    fs.Write(title, 0, title.Length);
            //    byte[] author = new UTF8Encoding(true).GetBytes("Andrew Troelsen");
            //    fs.Write(author, 0, author.Length);
            //}
            // Open the stream and read it back.    
            using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            string NewName = "";
            string lineOfText;
            string NewTextFile = "";
            using (var filestream = new FileStream(fileName,
                                 FileMode.Open,
                                 FileAccess.Read,
                                 FileShare.ReadWrite))
            {
                var file = new StreamReader(filestream, Encoding.UTF8, true, 15);

                while ((lineOfText = file.ReadLine()) != null)//here i reading line by line
                {
                    NewTextFile += lineOfText.Substring(0, 12) + "......." +
                    lineOfText.Substring(10, lineOfText.Length - 10);
                    NewTextFile += Environment.NewLine;//here i make new string
                }
            }

            NewName = fileName[1] + "\\temp.txt";
            System.IO.File.WriteAllText(NewName, NewTextFile);//here i save him



        }
    }
}
