//Swap two numbers without using a third variable.
//XOR (Bitwise) — Most Popular
//XOR means "one and only one, NOT both"

using System;
class program{
    static void Main(string[] args){
        int a, b;
        a = 13;
        b = 45;

        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

        a = a ^ b;   // a = 13 XOR 45
        b = a ^ b;   // b = original a
        a = a ^ b;   // a = original b

        Console.WriteLine("After swapping:  a = " + a + ", b = " + b);
    }
}

/*
a = 13  →  0 0 0 0 1 1 0 1
b = 45  →  0 0 1 0 1 1 0 1

Step 1: a = a ^ b
0 0 0 0 1 1 0 1   (13)
^ 0 0 1 0 1 1 0 1   (45)
─────────────────
  0 0 1 0 0 0 0 0   (32)   ← a is now 32


Step 2: b = a ^ b                    
    
  0 0 1 0 0 0 0 0   (32)  ← current a
^ 0 0 1 0 1 1 0 1   (45)  ← current b
─────────────────
  0 0 0 0 1 1 0 1   (13)  ← b is now 13 


Step 3: a = a ^ b                    
  
  0 0 1 0 0 0 0 0   (32)  ← current a
^ 0 0 0 0 1 1 0 1   (13)  ← current b
─────────────────
  0 0 1 0 1 1 0 1   (45)  ← a is now 45

*/
