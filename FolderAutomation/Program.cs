using System;
using System.IO;

class Program
{
    public static void Main()
    {
        int i = 1;
        for (i = 1; i <= 100; i++)
        {
            string folderpath;

            if (i < 9)
                folderpath = @"/Users/franklin/Desktop/100days-of-Phython/Demo0" + i;
            else
                folderpath = @"/Users/franklin/Desktop/100days-of-Phython/Demo" + i;

            string file = "Readme.text";

            Directory.CreateDirectory(folderpath);
            string finalpath = Path.Combine(folderpath, file);

            string data = "Demo File" + i;
            File.WriteAllText(finalpath, data);
        }
    }
}
