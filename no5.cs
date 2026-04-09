 //Convert temperature from Celsius to Fahrenheit. 
 using System;
 
 class program{
     static void Main(string[] args){
         
         double f = 0;
         Console.WriteLine("Enter temperature in Celsius: ");
         double c = Convert.ToInt32(Console.ReadLine());
         
         f = ((9*c)/5)+32;
         
         Console.WriteLine($"Temperature in Fahrenheit: {f}");
         
         
         
         
     }
     
     
     
     
 }
