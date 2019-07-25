using System;

namespace CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleNew = new Circle();
            //double number;
            bool repeat = true;
            int iteratons = 0;
            while (repeat)
            {
                try
                {
                    Console.WriteLine("Please enter a number for radius to calculate the area & circumference, mlord/mlady.\n");
                    string input = Console.ReadLine();
                    double radius = double.Parse(input);
                    circleNew.Radius = radius;
                    circleNew.PrintInfo();
                }
                catch(FormatException)
                {
                    Console.WriteLine("\nLiterally not a number. Try again, mlord/mlady.\n");
                    repeat = true;
                }
                Console.WriteLine("\nWould you like to continue?\n");
                string yesNo = Console.ReadLine();
                if(yesNo == "n")
                {
                    repeat = false;
                }
                else
                {
                    repeat = true;
                    
                }
               iteratons++;
            }
            Console.WriteLine($"\nYou made {iteratons} circles. See you later, nerd.");
        }
    }
}

    


