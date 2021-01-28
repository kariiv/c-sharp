using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Praktikum4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string path = @"List.txt";
            string pathWrite = @"Answers.txt";

            string extension = Path.GetExtension(path);
            string filename = Path.GetFileName(path);
            string fileUrl = Path.GetFullPath(path);

            Console.WriteLine("File path: {0}\nExtension: {1}\nName: {2}\n", fileUrl, extension, filename);
            ReadQuestions(path, pathWrite);
            

            Console.ReadLine();
        }
        /*
        static void SortLines(string pathWrite, string path)
        {
            List<string> mylist = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    mylist.Add(line);
                }
            }

            mylist.Sort();
            
            for (int e = 0; e < mylist.Count; e++)
                {
                    WritingText(pathWrite, mylist[e] + "\n" + Console.ReadLine());
                    
                }

        }*/

        static void ReadQuestions(string path, string pathWrite)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(pathWrite, true))
                {
                    string line;
                    int index = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nQuestion {0}: ", index);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(line);
                        writer.WriteLine(Console.ReadLine());
                        index++;
                    }
                }
                    
            } //reader is disposed
        }/*

        static void WritingText(string pathWrite, string addText)
        {
            using (StreamWriter writer = new StreamWriter(pathWrite, true))
            {
                writer.WriteLine(addText);
            }
        }

        static void OverwriteText(string pathWrite, string addText)
        {
            using (StreamWriter writer = new StreamWriter(pathWrite, false))
            {
                writer.WriteLine(addText);
            }
        }*/
        
    }
}
