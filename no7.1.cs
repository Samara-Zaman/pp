//Swap two numbers without using a third variable. 
//Arithmetic Approach
using System;
class program{
    static void Main(string[] args){
        int a, b;
        a = 13;
        b = 45;

        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

        a = a + b;   // a = 58
        b = a - b;   // b = 58 - 45 = 13
        a = a - b;   // a = 58 - 13 = 45

        Console.WriteLine("After swapping:  a = " + a + ", b = " + b);
    }
}
