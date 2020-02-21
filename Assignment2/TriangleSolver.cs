/*
 * Purpose: Creates a Triangle to solve
 *
 * Program: CPA
 *
 * Revision History:
 * Created by Igor Latychev
 * On February 14, 2020
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstDimension,
            int secondDimension, int thirdDimension)
        {
            string result;
            if (firstDimension + secondDimension > thirdDimension &&
                firstDimension + thirdDimension > secondDimension &&
                secondDimension + thirdDimension > firstDimension)
            {
                result = "This is a valid triangle";

                if (firstDimension == secondDimension &&
                    secondDimension == thirdDimension)
                {
                    result += " and this triangle is equilateral";
                }
                else if (firstDimension == secondDimension ||
                         firstDimension == thirdDimension ||
                         secondDimension == thirdDimension)
                {
                    result += " and this triangle is isosceles";
                }
                else
                {
                    result += " and this triangle is scalene";
                }

            }
            else
            {
                result = "This is not a valid triangle";
            }

            return result;
        }
    }
}
