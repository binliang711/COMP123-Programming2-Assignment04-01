/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:March 14th,2015
 * Program description:COMP123_Assignment04,Array Practice-Dice	Rolling	App.
 * Revision	History:
 * 1.Debug successfully.
 * 2.Improve comments.
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM123_Programming2_Assignment04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // random number generator
            Random randomNumbers = new Random(); 

            // When you roll two dice, there are 11 possible sums:
            // 2, 3, ..., 10, 11, 12. Define an array of 13 elements
            // where the first two elements are unused, but the third element
            // where index equals 2, corresponds to sum = 2, and so on.
            // make sure they're initialized to 0, which C# does by default
            int[] totaldie = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // for 36,000 times, roll two dice, calculate the sum,
            // and increment the index corresponding to that sum.
            for (int roll = 0; roll < 36000; roll++)
            {
                totaldie[randomNumbers.Next(1, 7) + randomNumbers.Next(1, 7)]++;
            }

            //display the face and frequnecy
            Console.WriteLine("{0}{1,10}", "Face", "Frequency");

            //output how many times each array elemtns value comes up
            int throws = 0;
            for (int face = 2; face < totaldie.Length; face++)
            {
                Console.WriteLine("{0,4}{1,10}", face, totaldie[face]);
                throws += totaldie[face];
            }

            //display the total throw times
            Console.WriteLine("Throws = {0}", throws);

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
