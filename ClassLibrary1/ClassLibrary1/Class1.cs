using System;
using System.Collections.Generic;
using System.Text;
namespace Maximum
{
    public class MaximumCls
    {         // Method 1: find maximum from two numbers
              public int Max(int x, int y)  {            
            return x > y ? x : y;         }          
        // Method 2: find maximum from three numbers
         public int Max(int x, int y, int z)   {
         if (x >= y && x >= z)
             return x;             
        else if (y >= x && y >= z)                
                return y;             
            return z;         
        }         
        // Method 3: find maximum from array
        public int Max(int[] array){             
            // If nothing is in the array
            if(array.Length == 0) {                
                return 0;             
            }              
            // Logic to find max from the array
            int max = array[0];             
            for (int i = 1; i < array.Length; i++)   {                 
                if (max < array[i])      {                    
                    max = array[i];                
                }             }             
            return max;        
        }   
    }
} 
 