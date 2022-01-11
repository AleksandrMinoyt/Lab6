using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputSring = Console.ReadLine();
            string[] arrayString = inputSring.Split();

            int maxLen = 0;
            string maxWord="";

            foreach ( string st in arrayString)
            {
                if(st.Length >maxLen)
                {
                    maxLen = st.Length;
                    maxWord = st;
                }
            }

            Console.WriteLine("самое длинное слово {0}, его длина {1} символов", maxWord, maxLen);
            Console.ReadKey();


        }
    }
}
