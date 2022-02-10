using System;

namespace CsharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            int x = 25;
            int y = 5;
            int sum = x + y;
            int differnce = x - y;
            int product = x * y;
            int quotient = x / y;
            int modulus = x % y;
            Console.WriteLine("Sum = {0} && Difference = {1} && product = {2} && Quotient = {3} && modulus = {4}", sum, differnce, product,quotient,modulus);

            //Question 2
            int varA = 5;
            int varB = ++varA;
            int varC = varB++;
            
            varA = 6;
            varB = 7;
            varC = 6;

            //Question 3

            int var1 = 6; 
            int var2 = ++var1; 
            int var3 = var2++;
            
            Console.WriteLine("var1 = {0}, var2 = {1}, var3 = {2}", var1, var2,var3);


            
            


            



        }
    }
}
