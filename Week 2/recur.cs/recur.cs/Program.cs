using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace recur.cs
{
    class Program
    {
        public static void ex1(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.ReadKey();
        }
        public static void ex2(string path) {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine("Files" + files.Length);
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo dirx in dirs)
            {
                Console.WriteLine(dirx.Name);
            }
                Console.ReadKey();
            }
        public static void emptySpaces(int p)
        {
            for (int i = 0; i < p * 2; i++) Console.Write('-');

        }
        public static void ex3(string path, int lvl)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                emptySpaces(lvl);
                Console.WriteLine("Files:" + dir.GetFiles().Length);
                foreach (FileInfo fil in dir.GetFiles())
                {

                    emptySpaces(lvl);
                    Console.WriteLine(fil.FullName);
                }
                emptySpaces(lvl);
                Console.WriteLine("Directories" + dir.GetDirectories().Length);
                foreach(DirectoryInfo dirx in dir.GetDirectories ())
                {
                    emptySpaces(lvl);
                    Console.WriteLine(dirx.FullName);
                    ex3(dirx.FullName, lvl + 1);

                }



            }
            catch (Exception e) 
            {
                Console.WriteLine("Error");
            }



        }
        public static void ex4(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Hello World!");
            sw.Close();
        }
        public static void ex5(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] arr = sr.ReadLine().Split();
            bool b = true;
            int maxx=0, minn=0;
            foreach (string s in arr)
            {
                int a = int.Parse(s);
                if (b == true)
                {
                    minn = a;
                    maxx = a;
                    b = false;
                }
                else
                {
                    if (a < minn) { minn = a; }
                    if (a > maxx) { maxx = a;
                }
                }


            }
            //     Console.BackgroundColor = ConsoleColor.Cyan;
         //   Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(minn);
            Console.WriteLine(maxx);
            Console.ReadKey();

        }
        public static void ex6(string path1,string path2)
        {
            StreamReader sr = new StreamReader(path1);
            StreamWriter sw = new StreamWriter(path2);
            string[] arr = sr.ReadLine().Split();
            foreach(string s in arr)
            {
                string[] p = s.Split(',');
                sw.WriteLine(p[0] + " - " + p[1]);

            }
            sw.Close();
            sr.Close();


        }
        public static void primem(string path, string path2)
        {
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(path2);
            string[] arr = sr.ReadLine().Split();
            bool b = true;
            int minn = 0;
            foreach (string s in arr)
            {
                int a = int.Parse(s);
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0) break;
                    if (i == (int)Math.Sqrt(a))
                    {
                        if (b == true)
                        {
                            minn = a;
                            b = false;
                        }
                        else
                        {
                            if (minn > a)
                            {
                                minn = a;
                            }
                        }
                    }
                }

            }


            //     Console.BackgroundColor = ConsoleColor.Cyan;
            //   Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (minn != 0)
            {
                sw.WriteLine(minn);
            }
            else
            {
                sw.WriteLine("All of these numbers are composite ;(");
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
           // string t = Console.ReadLine();
            ex5(s);
            Console.ReadKey(); 
        }
    }
}
