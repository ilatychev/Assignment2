/*
 * Purpose: To solve and analyze a triangle
 *
 * Program: CPA
 *
 * Revision History:
 * Program Created By Igor Latychev
 * On February 14, 2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declarations

            string userInput;
            bool validInput;
            int firstDimension;
            int secondDimension;
            int thirdDimension;
            bool resetMenu;

            // Initializations

            userInput = "";
            validInput = true;
            firstDimension = 0;
            secondDimension = 0;
            thirdDimension = 0;
            resetMenu = true;

            do
            {
                Console.WriteLine("Press 1 to Enter Triangle Dimensions");
                Console.WriteLine("Press 2 to Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                { 
                    Console.WriteLine("Enter Triangle Dimensions");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Enter Dimension 1: ");
                            firstDimension = int.Parse(Console.ReadLine());
                            validInput = true;
                        }
                        catch (Exception)
                        {
                            validInput = false;
                            Console.WriteLine("Please enter a number");
                        }
                    } while (!validInput);

                    do
                    {
                        try
                        {
                            Console.WriteLine("Enter Dimension 2: ");
                            secondDimension = int.Parse(Console.ReadLine());
                            validInput = true;
                        }
                        catch (Exception)
                        {
                            validInput = false;
                            Console.WriteLine("Please enter a number");
                        }
                    } while (!validInput);

                    do
                    {
                        try
                        {
                            Console.WriteLine("Enter Dimension 3: ");
                            thirdDimension = int.Parse(Console.ReadLine());
                            validInput = true;
                        }
                        catch (Exception)
                        {
                            validInput = false;
                            Console.WriteLine("Please enter a number");
                        }
                    } while (!validInput);

                    if (firstDimension + secondDimension > thirdDimension &&
                        firstDimension + thirdDimension > secondDimension &&
                        secondDimension + thirdDimension > firstDimension)
                    {
                        Console.WriteLine("This is a valid triangle");
                        if (firstDimension == secondDimension &&
                            secondDimension == thirdDimension)
                        {
                            Console.WriteLine("This triangle is equilateral");
                        }
                        else if (firstDimension == secondDimension ||
                                 firstDimension == thirdDimension ||
                                 secondDimension == thirdDimension)
                        {
                            Console.WriteLine("This triangle is isosceles");
                        }
                        else
                        {
                            Console.WriteLine("This triangle is scalene");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid triangle");
                    }
                }
                else if (userInput == "2")
                {
                    Environment.Exit(0);
                }
                else
                {
                    validInput = false;
                }
            } while (!validInput || resetMenu == true);
        }
    }
}
