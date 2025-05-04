using System;
using System.IO;

class Program
{
    public static void Main()
    {
        int i = 1;
        string file = "Readme.text";
        string content = "Demo File";
        string filepath = @"/Users/franklin/Desktop/100days-of-Phython/Demo";
        for (i = 1; i <= 100; i++)
        {
            string finalpath = Path.Combine(FolderPath(i, filepath), file);
            string data = content + i;
            File.WriteAllText(finalpath, data);
        }
    }

    private static string FolderPath(int i, string filepath)
    {
        Directory.CreateDirectory((i <= 9) ? filepath + "0" + i : filepath + i);
        return (i <= 9) ? filepath + "0" + i : filepath + i;
    }
}
