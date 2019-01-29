using System;
using System.IO;

namespace CountOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = getNumberFiles(@"C:\Users\Semih\Documents\cv");
            Console.WriteLine("" + num);
            Console.ReadLine();
        }

        public static int getNumberFiles(string path)
        {
            int number = Directory.GetFiles(path).Length;
            string[] directories = Directory.GetDirectories(path);

            for (int i = 0; i < directories.Length; i++)
                number += getNumberFiles(directories[i]);

            return number;
        }

    }
}
