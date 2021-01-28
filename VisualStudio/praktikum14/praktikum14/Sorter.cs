using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum14
{
    class Sorter
    {
        public void Sorting()
        {
            Console.WriteLine("SortingMachine");
            Random rnd = new Random();
            int[] numbers = new int[10];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-1000, 1000); //adding 10 random numbers to the array 
            }
            foreach (int e in numbers)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Sorted list\n"); //writing unsorted array 

            int[] sorted = ArraySort(numbers);

            foreach (int a in sorted)
            {
                Console.WriteLine(a);
            }
        }

        public int[] ArraySort(int[] array)
        {
            for (int a = 0; a < array.Length - 1; a++) //Loob to read numbers from start to the end of the array 
                for (int b = a; b >= 0; b--) //Loop that takes current positsion and goes down to the first positsion. In every loop it checks...
                    if (array[b] > array[b + 1]) //Idea is to check is the number bigger than number after that. If it's true, SWAP places by saveing data before writing it over.
                    {
                        int temp = array[b]; //temporary save data to the variable.
                        array[b] = array[b + 1]; //"move"(replace) value to the previous position.
                        array[b + 1] = temp; //And with the temp variable we can set replaced data to the higer position.
                    }
            return array; // returns sorted array after all numbers are checked
        }
    }
}
