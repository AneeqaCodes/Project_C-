using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Employee
    {
    }

    public class employee : iEmployee
    {
        private static int numEmployees = 0;

                        public employee()
        {
            
            throw new System.NotImplementedException();
        }
      

        public string firstName
        {
            get => default;
            set
            {
            }
        }

        public String lastName
        {
            get => default;
            set
            {
            }
        }

        public char gender
        {
            get => default;
            set
            {
            }
        }

        public int dependents
        {
            get => default;
            set
            {
            }
        }

        public double annualSalary
        {
            get => default;
            set
            {
            }
        }
    }
}