using System;
using System.IO;

namespace Lecture.Aids
{
    /*
    * Reading files for input involves working with streams and readers.
    */
    public static class ReadingInFiles
    {
        // Reading in a character file involves working with classes that derive from
        // TextWriter. TextWriter is an abstract class for working with character input.
        // The StreamReader inherits from TextWriter and that is often used.
        public static void ReadACharacterFile()
        {
            // Start with the file path to input
            //Step 1: locate the file in question
            string directory = Environment.CurrentDirectory;
            string filename = "Input.txt";

            // Create the full path
            //Step 2: create full path to file
            string fullPath = Path.Combine(directory, filename);

            // Wrap the effort in a try-catch block to handle any exceptions
            //Step 2: try/catch statement
            try
            {
                //Open a StreamReader with the using statement
                //Step 3: use a StreamReader to read the file data
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.
                    while (!sr.EndOfStream) //while streamreader hasnt completed, not at end of stream
                    {
                        // Read in the line
                        string line = sr.ReadLine(); 

                        // Print it to the screen
                        Console.WriteLine(line);
                        //read the line and print it to the screen
                        //can throw a large amount of exceptions down in the catch section
                    }
                }
            }
            catch(IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
