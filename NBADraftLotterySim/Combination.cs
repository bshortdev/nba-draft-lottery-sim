using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBADraftLotterySim
{
    class Combination
    {
        private static int[] lottoBalls = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        private static Combination invCombo = new Combination(11, 12, 13, 14);

        private int firstVal { get; set; }

        private int secondVal { get; set; }

        private int thirdVal { get; set; }

        private int fourthVal { get; set; }

        public Team team { get; set; }

        public Combination()
        {
            // Create a new Combination.
            generateCombination();
        }

        public Combination(int a, int b, int c, int d)
        {
            // Create a new Combination based on passed values.
            generateCombination(a, b, c, d);
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

        public void generateCombination(int a, int b, int c, int d)
        {
            // Create a set of booleans to check the uniqueness of the values.
            bool secondValValid = false;
            bool thirdValValid = false;
            bool fourthValValid = false;

            // Set the first value of the Combination.
            firstVal = a;

            // Set the second value of the Combination as long as it's unique from the first value.
            while (!secondValValid)
            {
                secondVal = b;
                if (secondVal != firstVal)
                {
                    secondValValid = true;
                }
            }

            // Set the third value of the Combination as long as it's unique from the first 2 values.
            while (!thirdValValid)
            {
                thirdVal = c;
                if ((thirdVal != firstVal) && (thirdVal != secondVal))
                {
                    thirdValValid = true;
                }
            }

            // Set the fourth value of the Combination as long as it's unique from the first 3 values.
            while (!fourthValValid)
            {
                fourthVal = d;
                if ((fourthVal != firstVal) && (fourthVal != secondVal) && (fourthVal != thirdVal))
                {
                    fourthValValid = true;
                }
            }
        }

        public static Combination[] makeLotteryPool()
        {
            List<Combination> lottery = new List<Combination>();

            // Cycle through array 4 times.
            for(int a = 0; a < 14; a++)
            {
                for (int b = 0; b < 14; b++)
                {
                    for (int c = 0; c < 14; c++)
                    {
                        for (int d = 0; d < 14; d++)
                        {
                            if(a==b || a==c ||a==d || b==c || b==d || c==d)
                            {
                                break;
                            }
                            Combination ball = new Combination(lottoBalls[a], lottoBalls[b], lottoBalls[c], lottoBalls[d]);
                            if (!Combination.findInList(ball, lottery) && !Combination.equalCombination(ball, invCombo))
                            {
                                lottery.Add(ball);
                            }
                        }
                    }
                }
            }
            return lottery.ToArray();
        }

        // Find a specific Combination in a List of Combinations
        public static bool findInList(Combination combo, List<Combination> list)
        {
            bool found = false;

            foreach(Combination c in list)
            {
                if(Combination.equalCombination(combo, c))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        // Compares 2 Combinations to see if they are equivalent.
        public static bool equalCombination(Combination compared, Combination comparedTo)
        {
            bool isEqual = false;
            if (findValue(compared.firstVal, comparedTo) && findValue(compared.secondVal, comparedTo) && findValue(compared.thirdVal, comparedTo) && findValue(compared.fourthVal, comparedTo))
            {
                isEqual = true;
            }
            return isEqual;
        }

        // Looks through a Combination to find the value passed to it.
        private static bool findValue(int value, Combination combo)
        {
            bool isValue = false;
            if(value == combo.firstVal || value == combo.secondVal || value == combo.thirdVal || value == combo.fourthVal)
            {
                isValue = true;
            }
            return isValue;
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
