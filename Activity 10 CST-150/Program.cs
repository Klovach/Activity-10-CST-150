using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Activity_10_CST_150
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ERROR DOCUMENTATION: 
            This program's error documentation can be found in set.cs, the set class.*/

            //Create new sets from the Set class. 
            Set A = new Set();
            Set B = new Set();
            //Put elements in the set. 
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //Display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));
            //Display original sets 
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }
}