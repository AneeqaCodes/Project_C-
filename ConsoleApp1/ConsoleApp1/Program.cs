using System;


namespace Parking
{
    abstract class Garage
    {

        public abstract void Cal_parking();
        }

    
    class Calculate : Garage
    {
        public override void Cal_parking()
        {
            int num1; int charge;
            int rent = 197; int extra = 187;
            Console.WriteLine($"Enter No of hours you want to park a car: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 16)
            {
                int i = num1 - 16;
                charge = rent + (extra * i);
                Console.WriteLine($"Parking fees is: {charge}");

            }
            else if (num1 < 16)
            {
                charge = rent;
                Console.WriteLine($"Parking fees is: {charge}");
            }
    }
}
class Main
{
    static void main(string[] args)
    {
        Calculate obj = new Calculate();
        obj.Cal_parking();

        Console.Write("Press any key to close the Parking console app...");
        Console.ReadLine();

    }
}
}
