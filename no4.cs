//Take two numbers and print their sum. 

using System;

class program{
        static void Main(string[] args){
            Console.WriteLine("Enter first value: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int j = Convert.ToInt32(Console.ReadLine());
            
            int sum = i + j;
            
            Console.WriteLine($"Sum of given numbers:{sum}");
            
            
            
        }
    
}
