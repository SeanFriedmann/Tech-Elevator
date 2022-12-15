using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("Please input the filesystem path");
            string fileSystemPath = Console.ReadLine();

            //2. Ask the user for the search string
            Console.WriteLine("Please input the word to look for");
            string word = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y/N)");
            string caseSensitive = Console.ReadLine();
            int lineCounter = 0;

            if (caseSensitive == "n")
               // int linecounter = 1;

            {
                word = word.ToLower();

                try
                {
                    using (StreamReader sr = new StreamReader(fileSystemPath))
                    {
                        while (!sr.EndOfStream)

                        {
                            string line = sr.ReadLine();
                            string lineTwo = line.ToLower();

                            lineCounter++;

                            if (lineTwo.Contains(word))
                            {

                                Console.WriteLine(lineCounter + ") " + line);
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //3. Open the file
            //string filename = Path.Combine(fileSystemPath, word);
           // StreamReader dataInput = new StreamReader(fileSystemPath);

           // int lineCount = 0;


                //4. Loop through each line in the file
            else 
            { int lineCount = 0;
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(fileSystemPath))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();

                                lineCount++;

                                if (line.Contains(word))
                                {
                                    //if (caseSensitive == "N")
                                    //{


                                    //}
                                    Console.WriteLine(lineCount + ") " + line);
                                }
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }



                    //5. If the line contains the search string, print it out along with its line number
                }
            }
        } } }
