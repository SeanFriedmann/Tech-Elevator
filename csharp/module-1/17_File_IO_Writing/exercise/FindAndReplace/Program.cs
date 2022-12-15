using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your search word?");
            string searchWord = Console.ReadLine(); //user input search word
            Console.WriteLine("What word to replace it with?");
            string replaceWord = Console.ReadLine(); //user input replacement word
            Console.WriteLine("Where is the source file?");
            
                string sourceFile = Console.ReadLine(); //user input source file
           
               
            
            Console.WriteLine("What is the location of the destination file?");
            
                string destinationFile = Console.ReadLine(); //user input destination file
            
          

            using (StreamReader sr = new StreamReader(sourceFile)) //using reader
            {
                using (StreamWriter sw = new StreamWriter(destinationFile, true)) //using writer
                {
                    while (!sr.EndOfStream) //while reader isnt at end of stream
                    {
                        string line = sr.ReadLine(); //read current line

                        string changedWord = line.Replace(searchWord, replaceWord); //replace search word with replacement

                        sw.WriteLine(changedWord); //input changed word
                    }
                }
            }
        }
    }
}
