using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//input as array of strings
            string[] arr = s.Split();//split each number as string
            foreach (string i in arr)//each number but it is string yet
            {
                int z = 1, x = 0;
                for (int j = 1; j < i.Length; j++) z *= 10;//how many digits does this number have
                foreach (char c in i)//each digit
                {
                    x += (c - '0') * z;//char to a number
                    z /= 10;
                }
                for (int j = 2; j <= (int)Math.Sqrt(x); j++)//every number%1=0 that's why we begin with 2 
                {
                    if (x % j == 0) break;//is it prime
                    if (j == (int)Math.Sqrt(x))//if it is prime
                    {
                        Console.Write(x);
                        Console.Write(' ');//space
                    }
                }
                if (x == 2||x==3)//x=2&&x==3 are prime but sqrt(x)<2
                    {
                        Console.Write(x);
                        Console.Write(' ');//space
                    }
                    }
            Console.WriteLine("\nPress any key to exit.");//4fun
            Console.ReadKey();//exit

        }
    }
}
