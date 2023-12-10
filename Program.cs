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
        Console.WriteLine("1: Comparing the speed of adding floats vs. doubles");

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
        Console.WriteLine("\n2: Comparing the speed of computing squares and square roots");

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

    // Function to generate an array of random double numbers
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

    // Function to generate an array of random float numbers
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

    // Function that adds numbers in the supplied 2D array (float version)
    static void AddNumbers(float[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    // Function that adds numbers in the supplied 2D array (double version)
    static void AddNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    // Function that multiplies numbers in the supplied 2D array
    static void MultiplyNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }

    // Function that computes squares using direct multiplication
    static void ComputeSquaresDirectly(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 0];
        }
    }

    // Function that computes squares using Math.Pow function
    static void ComputeSquaresWithMathPow(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Pow(nums[i, 0], 2);
        }
    }

    // Function that computes square roots using Math.Sqrt function
    static void ComputeSquareRootsWithMathSqrt(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Sqrt(nums[i, 0]);
        }
    }
}
