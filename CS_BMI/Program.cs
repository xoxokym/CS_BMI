using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("  Body Mass Index Calculator");
            Console.WriteLine("------------------------------");

            Console.WriteLine();

            // BMI Calculation Sytem
            Console.WriteLine("[S]: Standard");
            Console.WriteLine("[M] : Metric");

            Console.WriteLine();

            Console.Write("Choose a System of Your Calculation: ");
            char system = char.Parse(Console.ReadLine());

            Console.WriteLine();

            // Standard as User's Choice
            if (system == 'S')
            {
                Console.Write("Input Your Height in Inches: ");
                float height = float.Parse(Console.ReadLine());
                Console.Write("Input Your Weight in Pounds: ");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine();

                float BMI = (float) weight / (float) (height * height);
                float sBMI = BMI * 703;
                Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}", sBMI));

                Console.WriteLine();

                if (sBMI >= 30)
                {
                    Console.WriteLine("You are Obese.");
                }

                else if (sBMI >= 25)
                {
                    Console.WriteLine("You are Overweight.");
                }

                else if (sBMI >= 18.5)
                {
                    Console.WriteLine("You have a Normal Weight.");
                }
                
                else
                {
                    Console.WriteLine("You are Underweight.");
                }
            }

            // Metric as User's Choice
            else if (system == 'M')
            {
                Console.Write("Input Your Height in Meters: ");
                float height = float.Parse(Console.ReadLine());
                Console.Write("Input Your Weight in Kilograms: ");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine();

                float mBMI = (float) weight / (float) (height * height);
                Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}", mBMI));

                if (mBMI >= 30)
                {
                    Console.WriteLine("You are Obese.");
                }

                else if (mBMI >= 25)
                {
                    Console.WriteLine(" You are Overweight.");
                }

                else if (mBMI >= 18.5)
                {
                    Console.WriteLine("You have Normal Weight.");
                }

                else
                {
                    Console.WriteLine("You are Underweight.");
                }
            }

            // Invalid System Input
            else
            {
                Console.WriteLine("Invalid System Input.");
            }

            Console.ReadKey();
        }
    }
}
