//Check the data type size of int, double, and float. 

using System;
class program{
    static void Main(string[] args){
        Console.WriteLine("Data Type  | Size in Bytes | Size in Bits");
        Console.WriteLine("-----------|---------------|-------------");
        Console.WriteLine("int        | " + sizeof(int)    + "             | " + sizeof(int)    * 8);
        Console.WriteLine("double     | " + sizeof(double) + "             | " + sizeof(double) * 8);
        Console.WriteLine("float      | " + sizeof(float)  + "             | " + sizeof(float)  * 8);
    }
}
