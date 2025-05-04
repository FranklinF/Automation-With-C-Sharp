using System;
using System.IO;

class Program
{
    public static void Main()
    {
        int i = 1;
        string file = "Readme.text";
        string content = "Demo File";
        for (i = 1; i <= 100; i++)
        {
            string folderpath;
            folderpath = (i < 9) ? PathLocation() + i : PathLocation() + i;
            Directory.CreateDirectory(folderpath);
            string finalpath = Path.Combine(folderpath, file);
            string data = content + i;
            File.WriteAllText(finalpath, data);
        }

        static string PathLocation()
        {
            return @"/Users/franklin/Desktop/100days-of-Phython/Demo0";
        }
    }
}
