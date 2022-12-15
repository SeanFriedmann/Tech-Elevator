using System;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        * step 1: locate file and creaet path
        * step 2: try/catch for dangerous operations
        * step 3: use streamreader to read file data/ streamwriter to write file data
        */
        public static void WritingAFile()
        {
            //STEP 1
            string directory = Environment.CurrentDirectory; //get current directory file is in
            string filename = "output.txt";
            //streamwriter will make the file at the specified location, or can overwrite what is on the file

            //@ before file location to properly format
            string fullPath = Path.Combine(directory, filename);
            //create full path

            //STEP 2
            try
            {   //step 3
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.WriteLine("This is the start of my first file");
                    //like a console writeline, writes line to specified file
                    sw.Write("Hello ");
                    sw.Write("World!");

                    sw.WriteLine(); //empty line
                    sw.WriteLine("Tech Elevator!");
                    //great success

                } 


            }
            catch (IOException ex)
            {
                Console.WriteLine($"Opps something went wrong with {ex.Message}");
            }

            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
