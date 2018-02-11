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

    public class Day2
    {
        public void Calculate()
        {
            string input;
            List<int> resultList = new List<int>();
            using (StreamReader sr = new StreamReader("Day2/input.txt"))
            {
                while ((input = sr.ReadLine()) != null)
                {
                    var diffrence = CalculateDiffrence(input);
                    resultList.Add(diffrence);
                }
                System.Console.WriteLine(resultList.Sum());
            }
        }

        private int CalculateDiffrence(string input)
        {
            List<string> inpList = new List<string>();
            List<int> intList = new List<int>();

            //char[0] to remove whitespaces
            inpList = input.Split(new char[0]).ToList();
            foreach (var item in inpList)
            {
                intList.Add(Int32.Parse(item));
            }
            var max = intList.Max();
            var min = intList.Min();

            return max - min;
        }

        public void Run()
        {
            Calculate();
        }
    }
}