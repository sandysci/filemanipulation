using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace filemanipulationgoal2
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string mypath = @"C:\Users\USER\Documents\allfilework\hello.txt";// Create a path
            string[] myarray = new string[] {"cat","dog","sheep","lion","horse"};// creates an array
            File.WriteAllLines(mypath, myarray);// writes to the paths
           int length= File.ReadAllLines(@"C:\Users\USER\Documents\allfilework\hello.txt").Count();// counts it
           Console.WriteLine(length);// prints the length
           if (File.Exists(@"C:\Users\USER\Documents\allfilework\hello.txt")){// if the paths exists
               string[] myarrays = new string[] { "hen", "cat", "cows", "fish", "chicken" };// creating array
               File.AppendAllLines(mypath,myarrays);// appends the new array to the end of the file
               Console.WriteLine("DONE");// prints done to the console
           }
           Console.ReadLine();

           
            
            

        }
    }
}
