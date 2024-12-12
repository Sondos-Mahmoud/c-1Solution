using System;
using System.ComponentModel;
using System.IO;
//using static System.Console;

namespace c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Write a program that allows the user to enter a number then print it

            Console.Write("Enter a number: ");
            string x = Console.ReadLine();
            Console.WriteLine(x);
            #endregion

            #region q2
            /*
             Write C# program that Assigning one value type variable
            to another and modifying the value of one variable and 
            mention what will happen */
            int Z= 10; 
            int y = Z; 
            Console.WriteLine("Before modification: z = " + Z + ", y = " + y);
            y = 20; 
            Console.WriteLine("After modifying y: z = " + Z + ", y = " + y);
            /* Value types are copied So y is change  not like a refrence type*/
            #endregion

            #region q3
            /*Write C# program that Assigning one reference type variable to another
             and modifying the object through one variable and mention what will happen*/
            refrenceType r1 = new refrenceType();
            refrenceType r2 = new refrenceType();
            r1.x = 5;
            r2.x = 7;
            Console.WriteLine("Before modification: r1.x = " + r1.x + ",  r2.x = " +  r2.x);
            /* Reference types store references to objects in memory. When r1 is modified,
             * it affects r2 because they point to the same object.");*/
            r2 = r1;
            Console.WriteLine("Before modification: r1.x = " + r1.x + ",  r2.x = " + r2.x);


            #endregion

        }
    }
}
