using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FIZZBUZZ
/// When a factor of 3 is supposed to be displayed, print out FIZZ.
/// When a factor of 5 is supposed to be displayed, print out BUZZ.
/// When a factor of 3 and 5 is supposed to be displayed, print out FIZZ BUZZ.
/// </summary>

namespace FizzBuzzConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            //FizzBuzz fb = new FizzBuzz(10, 20);

            //foreach(string d in fb.results) { 
            //    Console.WriteLine(d);
            //}

            //Console.ReadLine();

            Console.WriteLine("Input the first number: ");
            string _1 = Console.ReadLine();

            Console.WriteLine("Input the second number: ");
            string _2 = Console.ReadLine();

            //conversion
            int one = Convert.ToInt32(_1);
            int two = Convert.ToInt32(_2);

            FizzBuzz fb = new FizzBuzz(one, two);
            //swap(ref one, ref two);

            foreach(string d in fb.results)
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();

        }

    }
}
