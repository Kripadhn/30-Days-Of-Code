using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int x=0;
        x=Convert.ToInt32(Console.ReadLine());
        double xd1;
        xd1=Convert.ToDouble(Console.ReadLine());
        string xs2;
        //="is the best place to learn and practice coding!";
        xs2=Console.ReadLine();
        // Print the sum of both integer variables on a new line.

        i=i+x;
        Console.WriteLine(i);
        // Print the sum of the double variables on a new line.
        d=d+xd1;
        string dxstr=String.Format("{0:0.0}", d);
        //d=Math.Round(dx,2);
        //Console.WriteLine(Math.Round(dx,1));
        Console.WriteLine(dxstr);
        // Concatenate and print the String variables on a new line
        s=s+xs2;
        Console.WriteLine(s);
        // The 's' variable above should be printed first.


    }