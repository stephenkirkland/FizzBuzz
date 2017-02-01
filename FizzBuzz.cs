using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class FizzBuzz
    {
        public string[] results;

        public FizzBuzz()
        {
            SetDefaultValues();
        }

        //contructor2
        public FizzBuzz(int input1, int input2)
        {
            swap(ref input1, ref input2);

            int diff = input2 - input1 + 1;
            
            results = new string[diff];
            //int d = input1;
            for (int i = input1; i <= input2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    int j = i - input1;
                    results[j] = "Fizz Buzz!";
                }
                else if (i % 3 == 0)
                {
                    int j = i - input1;
                    results[j] = "Fizz!";
                }
                else if (i % 5 == 0)
                {
                    int j = i - input1;
                    //int j = ((i > diff) ? i - diff + 1 : diff - i + 1);
                    results[j] = "Buzz!";
                }
                else
                {
                    int j = i - input1;
                    results[j] = Convert.ToString(i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetDefaultValues()
        {
            for (int i = 0; i < results.Length; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "Fizz Buzz!";
                }
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz!";
                }
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz!";
                }
                else
                {
                    results[i] = Convert.ToString(i);
                    //results[i] = "" + i;
                    //}
                }
            }
        }

        private static void swap(ref int one, ref int two)
        {
            if (two < one)
            {
                int temp = one;
                one = two;
                two = temp;
            }
        }

    }
}
