using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputSring = Console.ReadLine();
            string resultString="";

            int countOpenBkt = 0;          

            bool errorFlag = false;

            for (int i = 0; i < inputSring.Length; i++)
            {
                if (inputSring[i]=='{')
                {                   
                    countOpenBkt++;
                }

                if(countOpenBkt==0)
                {
                    resultString += inputSring[i];
                }


                if (inputSring[i] == '}')
                {
                    countOpenBkt--;
                }

                if(countOpenBkt<0)
                {
                    errorFlag = true;
                    break;
                }
                
            }

            if (!errorFlag)
            {
                Console.WriteLine(resultString);
            }
            else
            {
                Console.WriteLine("Ошибка!!!");
            }
            Console.ReadKey();
        }
    }
}
