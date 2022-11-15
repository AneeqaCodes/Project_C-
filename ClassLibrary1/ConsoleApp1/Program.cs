using System;
using Maximum;
namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {             // making the object maximum class
                      MaximumCls m1 = new MaximumCls();             
            // Input from user
            Console.WriteLine("Enter the number of integers you want: ");             
            int n = Convert.ToInt32(Console.ReadLine());             
            int[] array = new int[n];            
            for (int i = 0; i < n; i++) {                 
                Console.Write("Enter number " + (i + 1) + ": ");                 
                array[i] = Convert.ToInt32(Console.ReadLine());            
            }             
            // Call method based on user's input.
             int max = 0;              
            if (n == 2)   {                 
                max = m1.Max(array[0], array[1]);             
            }            
            else if (n == 3) {
                max = m1.Max(array[0], array[1], array[2]);            
            }            
            else            
            {                 
                max = m1.Max(array);             
            }              
            // Print the output
            Console.WriteLine("Max number is: " + max);            
            Console.ReadLine();        
        }     
    } 
} 


