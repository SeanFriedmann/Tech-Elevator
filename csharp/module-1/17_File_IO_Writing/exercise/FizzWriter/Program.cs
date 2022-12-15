using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("What is the source file?");
            //string sourceFile = Console.ReadLine();
            Console.WriteLine("Hello, where is the destination file?");
            string destinationFile = Console.ReadLine();
           // string currentDir = Environment.CurrentDirectory;
           // int lineCount = 0;

          //  using (StreamReader sr = new StreamReader(destinationFile))
            //using (StreamWriter sw = new StreamWriter(destinationFile, true))
            {
                using (StreamWriter sw = new StreamWriter(destinationFile))
                {

                    // while (!sr.EndOfStream)
                    //{
                    //while (lineCount <= 300)
                    //{

                    for (int i = 1; i <= 300; i++)
                    {
                        
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                           // sw.WriteLine(i);
                            sw.WriteLine("FizzBuzz");
                        }

                        else if (i % 3 == 0)
                        {

                           // sw.WriteLine(i);
                            sw.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                           // sw.WriteLine(i);
                            sw.WriteLine("Buzz");

                        }

                        else
                        {
                            sw.WriteLine(i);
                        }


                        //  }
                    } }
                }
            }
        }
    }

