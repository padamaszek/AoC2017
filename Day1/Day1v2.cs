using System;
using System.IO;

namespace AoC
{
    //The captcha requires you to review a sequence of digits (your puzzle input) and find the sum of all digits that match the next digit in the list. The list is circular, so the digit after the last digit is the first digit in the list.
    public class Day1v2
    {
        public string ReadInput()
        {
            string input;
            using (StreamReader sr = new StreamReader("Day1/input.txt"))
            {
                input = sr.ReadToEnd();
                Console.WriteLine("----------");
                Console.WriteLine("Input: {0}", input);
                Console.WriteLine("----------\n");
            }
            return input;
        }

        public void Run()
        {
            string input = ReadInput();
            CalculateCaptcha(input);
        }

        private void CalculateCaptcha(string input)
        {
            int sum = 0;
            char[] digits = input.ToCharArray();
            int jumpLength = digits.Length / 2;
            Console.WriteLine("----------");
            System.Console.WriteLine("Dlugosc skoku: {0}", jumpLength);
            Console.WriteLine("----------\n");
            for (int i = 0; i < digits.Length; i++)
            {
                int step = i + jumpLength;
                if (step < digits.Length && digits[i] == digits[step])
                {
                    sum += (int)char.GetNumericValue(digits[i]) + (int)char.GetNumericValue(digits[step]);
                }
            }
            Console.WriteLine("----------");
            System.Console.WriteLine("Suma: {0}", sum);
            Console.WriteLine("----------\n");
        }
    }
}