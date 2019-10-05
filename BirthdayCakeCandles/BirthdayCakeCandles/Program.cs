using System.IO;
using System;

class Solution
{
    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        int[] TallestCandles;

        int MaxNumber = Math.Max(ar[0], ar[1]);

        TallestCandles.push(MaxNumber);

        foreach (int candle in ar)
        {
            if (candle > TallestCandles[0])
            {
                TallestCandles[0] = candle;
            }
            else if (candle == TallestCandles[0])
            {
                TallestCandles.push(candle);
            }
        }

        int NunberOfCandles = TallestCandles.Length;

        return NunberOfCandles;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}



