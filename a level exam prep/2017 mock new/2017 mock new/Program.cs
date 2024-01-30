using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_mock_new
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ask for user plaintext
            Console.WriteLine("please enter your text to be encoded");
            string plainText = Console.ReadLine();

            //declare count to track letter appearances
            int count = 0;

            //show input and output displayed
            
            Console.WriteLine("Orginal Text: " + plainText);
            Console.Write("Compressed text: ");

            //loop character by character 
            for (int i = 0; i < plainText.Length; i++)
            {

                if (i == 0)
                {
                    count++;
                } 
                else if (plainText[i] == plainText[i - 1])
                {
                    count++;
                } 
                else
                {
                    Console.Write(plainText[i - 1] + " " + count + " ");
                    count = 1;
                }

            }
            Console.Write(plainText[plainText.Length - 1] + " " + count);

            Console.ReadLine();

        }
    }
}
