//Swap two numbers using a third variable. 

using System;

class program{
    static void Main(string[] args){
        
        Console.WriteLine("Enter first value: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second value: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        
        
        Console.WriteLine("Before swapping :a = "+ a +" b= " + b);
        
        int bucket;
        
        bucket = a; // at first, The first value should be in empty bucket
        a = b;
        b = bucket;
        
        Console.WriteLine("After swapping: a = "+ a +" b = " + b);
        
        
        
    }
    
    
}
