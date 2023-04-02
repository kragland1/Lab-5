//Grading ID: R2226
// Lab 5
// 3/6/2022
// CIS 199-02
// This program will prompt the user to enter valid temperatures and if not correct it will let them know


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //These are the list of variables and conditions
            int count = 0;
            double sum = 0;
            double mean;
            int temp = 0;
            bool valid = true; 
            int sentinel = 999;

            Console.WriteLine("Enter temperatures from -20 to 130 (999 to stop)");

            while (temp != sentinel) //A while loop for a certain conditions
            {
                Console.WriteLine("Enter temperature:");
                valid = int.TryParse(Console.ReadLine(), out temp);

                if (valid && temp >= -20 && temp <= 130)//Used for what needs to be counted if the input
                {
                    sum += temp;
                    count++;
                }
                else if ( !valid || temp != sentinel || temp < -20 && temp > 130) //Used for the other option
                {
                    Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature");
                }
            }
            mean = sum / count; // Needed to calculate the mean 
            Console.WriteLine("You entered {0} valid temperatures", count);// For the  end entry
            Console.WriteLine($"The mean temperature is {mean:F1} degrees"); // for the end entry
            



        }
    }
}
