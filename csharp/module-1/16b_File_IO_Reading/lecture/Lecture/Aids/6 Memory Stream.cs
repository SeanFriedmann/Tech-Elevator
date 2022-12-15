using System;
using System.IO;

namespace Lecture.Aids
{
    public class Memory_StreamSample
    {
        public static void ReadStream()
        {
            string folder = Environment.CurrentDirectory;
            string file = "input.txt";
            string fullPath = Path.Combine(folder, file);

            byte[] bytes = File.ReadAllBytes(fullPath); //file class has ability to read all the data in a file to a byte array
            Console.Write(bytes); //System.Byte[] boo
            //can get data out of file without streamreader, not for us rright now tho
        }
    }
}
