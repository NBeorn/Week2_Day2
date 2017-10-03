using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops are usually designed for counting
            for (int i = 1; i <= 10; i++)
            {
               //Console.WriteLine(i);
            }

            for (int counter = 50; counter <= 100; counter++)
            {
                //Console.WriteLine(counter);
                //Console.Write(counter + " ");
            }

            string greetings = "My name is Nick";
            string[] words = greetings.Split();
            for (int i = 0; i < words.Length; i++)
            {
                //Console.WriteLine(words[i]);
            }

            //Practice
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string sentence = "Once upon a time";
            //string[] storyWords = sentence.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //For each loop - always start at beginning and increment to the end, only works on collections

            //foreach (type Variable in collection)
            //{
            //
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] bands = { "Dance Gavin Dance", "Asking Alexandria", "blessthefall", "I See Stars", "A Day to Remember" };
            //foreach (string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //Practice
            string[] favoriteFoods = { "Pizza", "Chicken", "Steak", "Ribs" };
            foreach (string food in favoriteFoods)
            {
                Console.WriteLine(food);
            }

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine("Your lucky number is " + number);
            }
        }
    }
}
