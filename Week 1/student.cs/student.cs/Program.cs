using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.cs
{
    class Program
    {
        class student {
            // new variables
            public string n;
            public string s;
            public int a;
            public double g;
            public student(string n, string s, int a)
            {//attaching variables to "this"
                this.n = n;
                this.s = s;
                this.a = a;
            }  
            public double Getg()
            {// a.g
                return g;
            }
            public override string ToString()
            {
                return n + ' ' + s + ' ' + a + ' ' + g;
            }

        }
        static void Main(string[] args)
        {
            student b = new student( "Temirlan", "Omarov", 18 );//student's name surname age
            b.g = 2.39;//gpa
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
