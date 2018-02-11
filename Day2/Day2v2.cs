using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC
{
    /*
    It sounds like the goal is to find the only two numbers in each row where one evenly divides the other - that is, where the result of the division operation is a whole number.
    They would like you to find those numbers on each line, divide them, and add up each line's result.
     */

    public class Day2v2
    {
        public void Calculate()
        {
            string input;
            List<int> resultList = new List<int>();
            using (StreamReader sr = new StreamReader("Day2/input.txt"))
            {
                while ((input = sr.ReadLine()) != null)
                {
                    var parsedInput = ParseToInts(input);
                    var diffrence = CalculateDiffrenceInLine(parsedInput);
                    resultList.Add(diffrence);
                }
                System.Console.WriteLine(resultList.Sum());
            }
        }

        private List<int> ParseToInts(string input)
        {
            List<string> inputList = new List<string>();
            List<int> intList = new List<int>();

            //char[0] to remove whitespaces
            inputList = input.Split(new char[0]).ToList();
            //parse strings to ints
            foreach (var item in inputList)
            {
                intList.Add(Int32.Parse(item));
            }
            return intList;
        }

        private int CalculateDiffrenceInLine(List<int> input)
        {
            int higher = 0;
            int lower = 0;
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] % input[j] == 0 || input[j] % input[i] == 0)
                    {
                        higher = Math.Max(input[i], input[j]);
                        lower = Math.Min(input[i], input[j]);
                    }
                }
            }
            return higher / lower;
        }

        private void EvenDivide(int digit)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Calculate();
        }
    }
}