using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzz
    {
        public string Fizz(int numero)
        {
            if (fizz(numero))
            {
                return "fizz";
            }
            return numero.ToString();
        }
        private bool fizz(int numero)
        {
            return numero % 3 == 0;
            
        }

        public string Buzz(int numero)
        {
            if (buzz(numero))
            {
                return "buzz";
            }
            return numero.ToString();
        }
        private bool buzz(int numero)
        {
            return numero % 5 == 0;

        }

    }
}
