using System;
using System.Collections.Generic;
using System.Text;

namespace Fizzbuzz
{
    public class Fizzbuzzapp
    {
        public string GerarFizzBuzz(int atual)
        {
            if (atual % 3 == 0)
            {
                if ( atual % 5 == 0)
                {

                    return "FizzBuzz";
                }
                
             return "Fizz";

            } else if (atual % 5 == 0)
            {
                return "Buzz";
            } 
               
            return atual.ToString();
        }

        public string EntradaFizzBuzz()
        {
            string resultado = "";
            for (int i = 0; i <= 100; i++)
            {
                resultado += GerarFizzBuzz(i);
         
            }
            return resultado;
        }
    }
}