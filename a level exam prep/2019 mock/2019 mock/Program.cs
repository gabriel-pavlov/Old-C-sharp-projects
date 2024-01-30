using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_mock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ask for word that is to be created

            Console.WriteLine("please enter the word to be created");
            string word = Console.ReadLine();

            //ask for word used as resources

            Console.WriteLine("please enter the word to be rearranged");
            string rearranged = Console.ReadLine();

            // break down word to be created and place into array

            int[] wordCounter = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                int position = (Convert.ToInt32(word[i]) - 65);
                wordCounter[position] += 1;

            }

            // break down word to be rearranged and place into array

            int[] rearrangeCounter = new int[26];

            for (int i = 0; i < rearranged.Length; i++)
            {
                int position = (Convert.ToInt32(word[i]) - 65);
                rearrangeCounter[position] += 1;

            }

            // take away word array from rearrange array and check if negative

            bool isNegative = false;

            for (int i = 0; i < wordCounter.Length; i++)
            {
                if (wordCounter[i] > rearrangeCounter[i])
                {
                    isNegative = true;
                }


            }

            // 

            if (isNegative == true )
            {
                Console.WriteLine("letters cannot be rearranged to create word");
            } else 
            {
                Console.WriteLine("letters can be rearranged to create word");
            }

            Console.ReadLine();

        }
    }
}
