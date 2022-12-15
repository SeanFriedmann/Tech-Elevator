﻿using System;
using System.IO;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a file path - path should look like "data/jekyll-and-hyde.txt"
            Console.Write("Enter path to the book file: ");
            string filePath = Console.ReadLine();


            // Setup variables used in the loop
            // Count of lines between the start and end markers.
            int lineCount = 0;

            /*
            Step 2: Open a file for writing the converted text into it
            */
            string convertedPath = getConvertedPath(filePath);

            try
            {
                //open both the input and output files
                //using (StreamReader fileInput = new StreamReader(filePath)) ;
                using (StreamWriter writer = new StreamWriter(convertedPath))

                using (StreamReader fileInput = new StreamReader(filePath))
                {
                    // Loop until the end of file is reached
                    while (!fileInput.EndOfStream)
                    {

                        // Read the next line into 'lineOfText'
                        string lineOfText = fileInput.ReadLine();
                        lineCount++;

                        // Write the text in uppercase to the output file
                        writer.WriteLine(lineOfText.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("*** Problem reading specified file: " + ex.Message);
                return;
            }

            // Tell the user what happened.
            string message = $"Displayed {lineCount} lines of file {filePath} to {convertedPath} on {DateTime.Now}";
            Console.WriteLine(message);

            /*
            Step 3:
            Open a "log" file for append, to record all of the actions taken by this program
            throughout history. If the file doesn't exist it will be created. If it already exists, its
            contents will be preserved, and the lines written here will be appended to what was already there.
             */
            string auditPath = "BookConvert.log";
            //using streamwriter with true passed into the constructor opens the file for apprendtry{
            try
            {
                using (StreamWriter log = new StreamWriter(auditPath, true))
                {
                    log.WriteLine(message);
                } }
            catch (IOException ex)
            {
                Console.WriteLine("*** Problem writing log file: " + ex.Message);
            }
        }
    

        /**
        * This method gets the filename from the path sent in the argument, and creates another
        * path based on that filename, with ".screaming" inserted before the file extension.
        * So, an input path with the filename "myFile.txt" will return a path with the filename "myFile.screaming.txt".
        * If there is no extension on the input file ("myFile"), then ".screaming" will just be appended ("myFile.screaming").
        */
        static private string getConvertedPath(string bookPath)
        {
            // Insert ".screaming" into the book file path to arrive at a name for the converted file.
            int dotIndex = bookPath.LastIndexOf('.');
            string convertedPath;
            if (dotIndex >= 0)
            {
                // found an extension, like .txt
                convertedPath = bookPath.Substring(0, dotIndex) + ".screaming." + bookPath.Substring(dotIndex + 1);
            }
            else
            {
                // There is no file extension
                convertedPath = bookPath + ".screaming";
            }
            return convertedPath;
        }
    }
}