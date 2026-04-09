//Tuple (Modern C# — Cleanest)                    
                      
  
using System;
class program{
    static void Main(string[] args){
        int a, b;
        a = 13;
        b = 45;

        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

        (a, b) = (b, a);   // One-liner swap ✨

        Console.WriteLine("After swapping:  a = " + a + ", b = " + b);
    }
}
