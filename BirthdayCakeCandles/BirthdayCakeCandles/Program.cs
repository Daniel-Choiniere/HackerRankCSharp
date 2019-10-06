using System.IO;
using System;
using System.Collections.Generic;

class Solution
{
    // Complete the birthdayCakeCandles function below.
    static int BirthdayCakeCandles(int[] ar)
    {
        //Decided to go with a List instead of an array to be able to use List methods
        List<int> TallestCandles = new List<int>();

        int MaxNumber = Math.Max(ar[0], ar[1]);

        Console.WriteLine(MaxNumber);

        //Now we can use the Add() method instead of the non-existent push to Array I had originally tried
        TallestCandles.Add(MaxNumber);

        foreach (int candle in ar)
        {
            if (candle > TallestCandles[0])
            {
                TallestCandles[0] = candle;
            }
            else if (candle == TallestCandles[0])
            {
                TallestCandles.Add(candle);
            }
        }

        //When I loop I always get the original MaxNumber in the TallestCandles array so I just need to -1 to account for that
        int NumberOfCandles = TallestCandles.Count - 1;

        return NumberOfCandles;
    }


    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = BirthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

