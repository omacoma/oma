using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex.cs
{
    class Program
    {
        static int GCD(int a, int b)//GCD function 
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
        class complex
        {            int x;
            int y;
            public complex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void print ()
            {
                Console.WriteLine(x + "/" + y);
            }
            public override string ToString()
            {
                if (y == 1) return x.ToString();
                return x + "/" + y;
            } 
            public static complex operator +(complex c1, complex c2)
            {
                int a = c1.x * c2.y + c2.x * c1.y;
                int b = c2.y * c1.y;
                int c = GCD(a, b);
                a /= c;
                b /= c;
                complex c3 = new complex(a, b);
                return c3;
            }
        }
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string[] arr = inp.Split();
            complex sum= new complex(0,0);
            bool b = false;
            foreach (string s in arr)
            {
                string[] t = s.Split('/');
                complex p = new complex(int.Parse(t[0]), int.Parse(t[1] ));
                if (!b) { sum = p; b = true; }
                else
                    sum += p; 

            }
            Console.WriteLine(sum); 
            Console.ReadKey();
        }
    }
}
