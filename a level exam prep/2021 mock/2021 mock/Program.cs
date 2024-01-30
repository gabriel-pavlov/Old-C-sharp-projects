using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_mock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Get input function




            Console.WriteLine("please enter a number you'd like to see");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            int i = 1;
            
            int counter = 0;

            while (true)
            {

                int[] digits = GetDigitArray(i);
                int sum = DigitAdder(digits);
                
                if ( i % sum == 0)
                {
                    counter++;
                } 

                if (counter == number)
                {
                    Console.WriteLine(number + "th harshad number is " + i);
                    Console.ReadLine();
                    break;
                }

                i++;
            }



        }



        static int[] GetDigitArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        static int DigitAdder(int[] digitArray)
        {
            int sum = 0;

            for (int ii = 0; ii < digitArray.Length; ii++)
            {

                sum += digitArray[ii];


            }
            return sum;

        }
    }
}
