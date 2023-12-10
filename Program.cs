using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000;
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        // Question 1: Comparing the speed of adding floats vs. doubles
        Console.WriteLine("1:- Comparing the speed of adding floats vs. doubles");

        float[,] floatNumbers = GenRandomFloatNumbers(n);
        double[,] doubleNumbers = GenRandomNumbers(n);

        timer.Start();
        AddNumbers(floatNumbers, n);
        timer.Stop();
        Console.WriteLine("Adding floats took: " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        // Reset arrays
        floatNumbers = GenRandomFloatNumbers(n);
        doubleNumbers = GenRandomNumbers(n);

        timer.Reset();
        timer.Start();
        AddNumbers(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Adding doubles took: " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        // Question 2: Comparing the speed of computing squares and square roots
        Console.WriteLine("\n2:- Comparing the speed of computing squares and square roots");

        numbers = GenRandomNumbers(n);

        // Compute squares using direct multiplication
        timer.Reset();
        timer.Start();
        ComputeSquaresDirectly(numbers, n);
        timer.Stop();
        Console.WriteLine("Computing squares directly took: " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        // Reset array
        numbers = GenRandomNumbers(n);

        // Compute squares using Math.Pow function
        timer.Reset();
        timer.Start();
        ComputeSquaresWithMathPow(numbers, n);
        timer.Stop();
        Console.WriteLine("Computing squares with Math.Pow took: " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        // Reset array
        numbers = GenRandomNumbers(n);

        // Compute square roots using Math.Sqrt function
        timer.Reset();
        timer.Start();
        ComputeSquareRootsWithMathSqrt(numbers, n);
        timer.Stop();
        Console.WriteLine("Computing square roots with Math.Sqrt took: " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    }

    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count, 3];
        for (int i = 0; i < count; ++i)
        {
            num[i, 0] = 10000.0 * rand.NextDouble();
            num[i, 1] = 10000.0 * rand.NextDouble();
        }
        return num;
    }

    static float[,] GenRandomFloatNumbers(int count)
    {
        Random rand = new Random();
        float[,] num = new float[count, 3];
        for (int i = 0; i < count; ++i)
        {
            num[i, 0] = (float)(10000.0 * rand.NextDouble());
            num[i, 1] = (float)(10000.0 * rand.NextDouble());
        }
        return num;
    }

    static void AddNumbers(float[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    static void AddNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    static void MultiplyNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }

    static void ComputeSquaresDirectly(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 0];
        }
    }

    static void ComputeSquaresWithMathPow(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Pow(nums[i, 0], 2);
        }
    }

    static void ComputeSquareRootsWithMathSqrt(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Sqrt(nums[i, 0]);
        }
    }
}
