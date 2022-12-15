using System;
using System.IO;

namespace Lecture.Aids
{
    /*
    * A path is a string that provides the location of a file or directory.
    *
    * Working with paths is kind of tricky.
    *
    * The Path class is a static class that is able to perform operations
    * on strings that represent folders and file paths.
    *
    */
    public static class FilePaths
    {
        /*
        * The path class helps create a full path given a directory
        * and file name.
        */
        public static void UsingPathToCombineTwoFilePaths()
        {
            string path1 = @"C:\Temp\Directory";
            string filename = @"filename.txt";

            // Generating a full path from a folder and a file name
            string fullPath = Path.Combine(path1, filename); //will print C:\Temp\Directory\filename.txt
            //combine will handle some parameters and behind the scenes error handling for you
            //all we are doing is creating the path to filename.txt
        }

        //Windows \
        //Linux /
        
        /*
        * The path class helps by getting the extension in a file name.
        */
        public static void GettingExtensions()
        {
            string path = @"C:\Temp\path.txt";

            // Get the extension from the path variable
            string extension = Path.GetExtension(path); //.txt

            // Change the extension in the path variable to .cs
            Path.ChangeExtension(path, ".cs"); //change from text file to c sharp file
        }



        public static void UsingPathForTemporaryFolders()
        {

            // Generate a temporary path folder and file
            Console.WriteLine("{0} is the location for temporary files.", Path.GetTempPath());
            Console.WriteLine("{0} is a file available for use.", Path.GetTempFileName()); //make you a nice new empty temp file, will always work

            /* This code produces output similar to the following:
             * c:\temp\MyTest.txt has an extension.
             * c:\temp\MyTest has no extension.
             * The string temp contains no root information.
             * C:\Documents and Settings\John\Local Settings\Temp\8\ is the location for temporary files.
             * C:\Documents and Settings\John\Local Settings\Temp\8\tmp3D.tmp is a file available for use.
             */
        }
    }
}
