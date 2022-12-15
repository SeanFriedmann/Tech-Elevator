using System;
using System.IO;

namespace Lecture.Aids
{
    public static class ReadingAndWritingFiles
    {
        public static void OpenAndWrite()
        {
            // Figure the full path of the input file and output file
            string directory = Environment.CurrentDirectory;
            string inputFile = "programminglanguages.txt";
            string outputFile = "programminglanguages-FIXED.txt";
            string inputFullPath = Path.Combine(directory, inputFile); //input file
            string outputFullPath = Path.Combine(directory, outputFile); //output file

            // Open the existing file with the typo using a StreamReader
            using (StreamReader sr = new StreamReader(inputFullPath)) //read programminglanguage.txt
            {
                // Open a StreamWriter where we will output the file
                using (StreamWriter sw = new StreamWriter(outputFullPath, true)) //true at the end we want to append to the end of the file
               //write to programminglanguages-FIXED.txt
                {
                    // For each line in the input file, read it in
                    while (!sr.EndOfStream) //while we havent reached the end of the stream
                    {
                        // Read an individual line
                        string line = sr.ReadLine(); //read each line and save it to a variable

                        // Replace the occurence of the word langauge with language
                        string fixedLine = line.Replace("langauge", "language"); //fixed line is the current line with the replacement for correct spelling

                        // Write the new line to the output file
                        sw.WriteLine(fixedLine); //input the fixed spelling into the line
                    }
                }
            }
        }
    }
}
