using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class FizzBuzz2
    {
        public string[] results;

        public FizzBuzz2()
        {

        }

        public FizzBuzz2(int input1, int input2)
        {
            int diff = input2 - input1 + 1;
            results = new string[diff];

            for (int i = input1; i <= input2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    int j = i - diff + 1;
                    results[j] = "Fizz Buzz!";
                }
                else if (i % 3 == 0)
                {
                    int j = i - diff + 1;
                    results[j] = "Fizz!";
                }
                else if (i % 5 == 0)
                {
                    int j = i - diff + 1;
                    results[j] = "Buzz!";
                }
                else
                {
                    int j = i - diff + 1;
                    results[j] = Convert.ToString(i);
                }
            }
        }

    }
}
