using System;
using System.Drawing;
using System.IO;

namespace Lecture.Aids
{
    public class BinaryImageManipulator
    {
        public static void ReadFileIn()
        {
            //string folder = Environment.CurrentDirectory;
            string folder = @"C:\Users\Student\git\sean-friedmann-student-code\csharp\module-1\17_File_IO_Writing\lecture\Lecture";
            string filename = "rick.jpg";
            string fullpath = Path.Combine(folder, filename);

            byte[] bytes = File.ReadAllBytes(fullpath); //file data into byte array
            using (MemoryStream ms = new MemoryStream(bytes)) //type of stream that we can flow through
            {
                using (Image img = Image.FromStream(ms)) //using statement specifically for images
                {
                    Bitmap bmp = new Bitmap(img); //new bit map image
                    for (int x = 0; x < bmp.Width; x++) //starts at 0, goes until width of image, one byte at a time
                    {
                        for (int y = 0; y < bmp.Height; y++) //goes until height of image
                        {
                            Color oldPixel = bmp.GetPixel(x, y); //um
                            //bmp.SetPixel(x, y, Color.FromArgb(oldPixel.R, oldPixel.G, 20));
                            bmp.SetPixel(x, y, Color.FromArgb(oldPixel.R, Color.FromKnownColor(KnownColor.Gray))); //change color to gray
                        }
                    }

                    bmp.Save(Path.Combine(folder, "output.jpg")); //save output to output.jpg
                }
            }
        }
    }
}
