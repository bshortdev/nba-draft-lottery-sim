using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class Combination
    {
        private int[] lottoBalls = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        private int firstVal { get; set; }

        private int secondVal { get; set; }

        private int thirdVal { get; set; }

        private int fourthVal { get; set; }

        public Combination()
        {
            // Create a new Combination.
            generateCombination();
        }

        public void generateCombination()
        {
            // Create a set of booleans to check the uniqueness of the values.
            bool secondValValid = false;
            bool thirdValValid = false;
            bool fourthValValid = false;

            // Set the first value of the Combination.
            firstVal = randArrayVal(lottoBalls);

            // Set the second value of the Combination as long as it's unique from the first value.
            while (!secondValValid)
            {
                secondVal = randArrayVal(lottoBalls);
                if(secondVal != firstVal)
                {
                    secondValValid = true;
                }
            }

            // Set the third value of the Combination as long as it's unique from the first 2 values.
            while (!thirdValValid)
            {
                thirdVal = randArrayVal(lottoBalls);
                if ((thirdVal != firstVal) && (thirdVal != secondVal))
                {
                    thirdValValid = true;
                }
            }

            // Set the fourth value of the Combination as long as it's unique from the first 3 values.
            while (!fourthValValid)
            {
                fourthVal = randArrayVal(lottoBalls);
                if ((fourthVal != firstVal) && (fourthVal != secondVal) && (fourthVal != thirdVal))
                {
                    fourthValValid = true;
                }
            }
        }

        // Prints the 4 values of the Combination
        public static string printCombination(Combination source)
        {
            return source.firstVal + " - " + source.secondVal + " - " + source.thirdVal + " - " + source.fourthVal;
        }

        // Method ensures a random value is picked from the array of lottery balls.
        private int randArrayVal(int[] arr)
        {
            int len = arr.Length;
            Random rnd = new Random();
            int index = rnd.Next(0, len);
            return arr[index];
        }
    }
}
