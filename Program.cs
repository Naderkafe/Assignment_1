//Nader Kafe            Z1949619                Code:- september 18th, 2023
//**********************************************************************//
using System; // Import the System namespace, which contains fundamental types and base classes
using System.Diagnostics;
class Program
{
    static void Main()
    {
        int n = 800000; // Number of random numbers to generate
        double[,] numbers; // Declare a 2D array to store random numbers
        Stopwatch timer = new Stopwatch(); // Stopwatch to measure execution time

        // Generate random numbers and store them in the 'numbers' array
        numbers = GenRandomNumbers(n);

        // Start measuring time
        timer.Start();

        // Perform addition operation on the 'numbers' array
        AddNumbers(numbers, n);

        // Stop measuring time
        timer.Stop();

        // Display results for addition
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");

        float addTicks = (float)timer.ElapsedTicks;           // Store elapsed ticks for addition
        timer.Restart();                                      // Restart the timer for the multiplication operation
        MultiplyNumbers(numbers, n);              // Perform multiplication operation on the 'numbers' array
        timer.Stop();                                         // Stop measuring time
        Console.WriteLine("Multiplications");          // Display results for multiplication
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");

        float multTicks = (float)timer.ElapsedTicks; // Store elapsed ticks for multiplication

        // Calculate and display the ratio of addition time to multiplication time
        Console.WriteLine("Ratio = " + addTicks / multTicks);
    }
    static double[,] GenRandomNumbers(int count)    // Function to generate an array of random double numbers
    {
        Random rand = new Random();     // instantiate (Create a new instance) of the Random class to generate random numbers
        double[,] num = new double[count,3]; // Declare(make) an array 'num' to store double values with the specified 'count'
        for (int i = 0; i < count; ++i) // Iterate through the 'num' array and assign random double values
        {
            num[i,0] = 10000.0 * rand.NextDouble(); // Generate a random double value between 0 and 100 and store it in the array
            num[i,1] = 10000.0 * rand.NextDouble(); // Generate random number between 0 and 10000  //**** or ****// fill in elements of array
        }
        return num;  // Return the array of double numbers
    }            // returns reference to array
    // Function that adds numbers in the supplied 2D array
static void AddNumbers(double[,] nums, int count)
    {   int i; // Declare a variable 'i' for the loop
        for (i = 0; i < count; ++i){  // Iterate through the rows of the 'nums' array
        nums[i, 2] = nums[i, 0] + nums[i, 1];  // Add the values in the first and second columns of each row and store the result in the third column
        }
    }
// Function that multiplies numbers in the supplied 2D array
static void MultiplyNumbers(double[,] nums, int count)
    {   int i; // Declare a variable 'i' for the loop
        for (i = 0; i < count; ++i){// Iterate through the rows of the 'nums' array
        nums[i, 2] = nums[i, 0] * nums[i, 1];   // Multiply the values in the first and second columns of each row and store the result in the third column
        }
    }
}