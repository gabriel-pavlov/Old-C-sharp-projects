using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_mock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declare array of length 10 where digit counts kept
            int[] digits = new int[10];
            
            

            //get number of digits required
            Console.WriteLine("how many numeric digits would you like to enter?");
            int number = Convert.ToInt32(Console.ReadLine());

            //loop to ask for digits and increment count in array

            for (int i = 0; i < number; i++)
            {

                Console.WriteLine("please enter a digit");
                int cDigit = Convert.ToInt32(Console.ReadLine());
                digits[cDigit] += 1;

            };

            // find max count in array, index will be most frequent number ( if multiple peaks then print message)

            int max = 0;
            int maxIndex = 0;
            bool repeat = false;

           for (int i = 0;i < digits.Length; i++)
            {
                int count = digits[i];
                if (count > max)
                {
                    max = count; 
                    maxIndex = i;
                    repeat = false;
                } else if (count == max)
                {
                    repeat = true;
                    
                };

                

            };

            // output results

            if (repeat)
            {
                Console.WriteLine("Data was multimodal");
            } else
            {
                Console.WriteLine("maximum frequency " + max + " for value " + maxIndex);
                
            }
            Console.ReadLine();
        }
    }
}
