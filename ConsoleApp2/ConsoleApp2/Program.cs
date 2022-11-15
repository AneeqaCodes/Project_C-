using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stamp
    {

        double travel, rate, price;


        public void cal_stamps()
        {



            Console.WriteLine("Enter Weight of an article in .oz: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Zone of an article to which it travels: ");
            double zone = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Press \" 0 for Local \" OR \" 1 for Air Mail\": ");
            travel = Convert.ToInt32(Console.ReadLine());

            if (travel == 0)
            {
                rate = 0.49;
                if (weight <= 0.50)
                {
                    Console.WriteLine($"Rate of the stamp is : {rate}");
                }
                else if (weight > 0.50)
                    
                {
                    if (zone == 1)
                    {
                        price = rate+(rate * (weight-0.5) * 0.50);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else if (zone == 2)
                    {
                        price=rate + (rate * (weight-0.5) * 0.65);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else if (zone == 3)
                    {
                        price =rate + (rate * (weight-0.5) * 0.80);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else
                    {
                        Console.WriteLine("Enter the correct Zone!");
                    }
                }
            }
            else if (travel == 1)
            {
                rate = 0.95;
                if (weight <= 0.50)
                {
                    Console.WriteLine($"Rate of the stamp is {rate}");


                }

                else if (weight > 0.50)
                {
                    if (zone == 1)
                    {
                        price =rate + (rate * (weight-0.5) * 0.50);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else if (zone == 2)
                    {
                        price =rate +(rate * (weight-0.5) * 0.60);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else if (zone == 3)
                    {
                        price =rate + (rate * (weight-0.5) * 0.90);
                        Console.WriteLine($"Rate is :  {price}");
                    }
                    else
                    {
                        Console.WriteLine("Enter the correct input");
                    }

                }
            }

            else
            {
                Console.WriteLine("Enter a valid number!");
            }
        }


        static void Main(string[] args)

        {
            Stamp obj = new Stamp();
            obj.cal_stamps();
        }
    }
}

