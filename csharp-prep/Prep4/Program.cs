using System;
using  System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // now use while
        int usNumber = -1;
        while(usNumber != 0)
        {
            Console.Write(" Enter a number, 0 to quit : ");
            string userResp = Console.ReadLine();
            usNumber= int.Parse(userResp);
            if (usNumber != 0)
            {
                numbers.Add(usNumber);
            }
        }
        // do the sum
        int sum =0;
        foreach (int number in numbers)
        {
          sum += number;  
        }
        Console.WriteLine($"The sum is {sum}");

        // Average
        float average = ((float)sum)/numbers.Count();
        Console.WriteLine($"The average is {average}");

        // The max number

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
            Console.WriteLine($"the max number is {max}") ;

            // print the list
            foreach (int number in numbers)
            {
              Console.WriteLine(number);  
            }
        }

    }
