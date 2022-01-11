using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputSring = Console.ReadLine();
            string[] arrayString = inputSring.Split();
            string tempString = "";

            foreach ( string st in arrayString)
            {
                tempString += st.ToLower();
            }

            string tempString2 = "";

            for (int i = tempString.Length-1; i >=0 ; i--)
            {
                tempString2 += tempString[i];
            }


            if(tempString.Equals(tempString2))
            {
                Console.WriteLine(@"'"+inputSring+@"' палиндром");
            }
            else
            {
                Console.WriteLine(@"'" + inputSring + @"'не палиндром");
            }
                       
            Console.ReadKey();

        }
    }
}
