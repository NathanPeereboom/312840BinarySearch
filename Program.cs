/* Nathan Peereboom
 * April 24, 2020
 * Binary Search Algorithm
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312840BinarySearch
{
    class Program
    {
        static int[] data = new int[17];
        static int mark1;//Left hand boundry of scope of search
        static int mark2;//Right hand boundry of scope of search
        static int search;//Number to search for
        static int mid = -1;//Number in middle of scope

        static void Main(string[] args)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i * 2;
            }
            mark1 = 0;
            mark2 = data.Length - 1;

            Console.WriteLine("Enter a number to search:");
            int.TryParse(Console.ReadLine(), out search);

            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("Search " + counter + ":");
                Console.WriteLine("Searching between indexes " + mark1 + " and " + mark2);
                if (mark2 < mark1)
                {
                    Console.WriteLine("No results found");
                    break;
                }
                compare();
            } while (data[mid] != search);
            //End program
            Console.ReadLine();
        }

        public static void compare()
        {
            mid = (mark2 + mark1) / 2;
            Console.WriteLine("mid index: " + mid + "; mid value: " + data[mid]);
            if (data[mid] == search)
            {
                Console.WriteLine("Found it");
            }
            else if (data[mid] < search)
            {
                Console.WriteLine("Too low");
                mark1 = mid + 1;
            }
            else if (data[mid] > search)
            {
                Console.WriteLine("Too high");
                mark2 = mid - 1;
            }
        }
    }
}
