using System;
using System.IO;

class Program
{
    public static void Main()
    {
        int i = 1;
        for (i = 1; i <= 100; i++)
        {
            CreateFolder(i);
        }
    }

    private static void CreateFolder(int i)
    {
        string file = "Readme.text";
        string content = "Demo File";
        string filepath = @"/Users/franklin/Desktop/100days-of-Phython/Demo";
        string fullpath = (i <= 9) ? filepath + "0" + i : filepath + i;
        Directory.CreateDirectory(fullpath);
        string finalpath = Path.Combine(fullpath, file);
        string data = content + i;
        File.WriteAllText(finalpath, data);
    }
}
