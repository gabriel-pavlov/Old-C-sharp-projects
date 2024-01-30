using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_mock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //get user input string
            Console.WriteLine("please enter your text to be encoded");
            string plainText = Console.ReadLine();

            //run loop that checks if previous and add to RLE array
            char[] resultText = new char[(plainText.Length * 2)];
            int count = 1;
            int tracker = 0;
            for (int i = 0; i < plainText.Length; i++)
            {
                if (i == 0)
                {
                    resultText[tracker] = plainText[i];
                    resultText[tracker + 1] = Convert.ToChar(count);
                    Console.WriteLine(Convert.ToString(resultText[tracker])+ " " + Convert.ToString(resultText[tracker + 1]));
                    Console.ReadLine();
                } else if (plainText[i] == plainText[i - 1]) 
                {
                    count++;
                    resultText[tracker + 1] = Convert.ToChar(count);
                    Console.WriteLine(Convert.ToString(resultText[tracker]) + " " + Convert.ToString(resultText[tracker + 1]));
                    Console.ReadLine();
                } else
                {   

                    tracker = tracker + 2;
                    resultText[tracker] = plainText[i];
                    count = 1;
                    Console.WriteLine(Convert.ToString(resultText[tracker]) + " " + Convert.ToString(resultText[tracker + 1]));
                    Console.ReadLine();
                }


            }





        }
    }
}
