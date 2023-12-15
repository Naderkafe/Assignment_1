# First Programming Assignment
In class, we wrote a program that we used to attempt to answer the following question:Which
can the computer perform faster: adding two doubles together or multiplying two doubles? 
Our program created arrays of 800,000 pairs of random numbers to add together and then used 
thebuilt-in Stopwatch class to time the operations.In this assignment, I want you to modify
the code in effort to create your own experiments to run. Inthese experiments, I want you
to answer two questions: One question from Group A below, and onefrom Group B.
## Group A
* Which is faster: adding two floats together, or two doubles? To do this one, you’re going
  tohave to create two separate arrays: one with floats, and the other with doubles. To do
  a faircomparison, both arrays will need to have (essentially) the same sets of numbers
  that are addedtogether. First create the array of random doubles. Then cast those doubles
   into floats to fill thesame-size array of floats. You’ll probably need two different
   functions which computes the sum.
* Which is faster: adding two ints together or multiplying two ints? Also compare to how
  long ittakes to add and multiply doubles? You may run into the same issues described above.
## Group B
* Which is faster: computing the square of a double via direct multiplication, or computing thesquare using the built in function Math.Pow function? Also compare these to the built-insquare root function: Math.Sqrt function.
* Which is faster: computing the sine of an angle using the built-in function Math.Sin, or bycalculating a quintic Taylor series approximation: 𝒙 − 𝟏𝟔 𝒙𝟑 + 𝟏𝟏𝟐𝟎 𝒙𝟓? Also compare the cosinefunction Math.Cos
* Which is faster: computing the exponential (i.e. 𝒆𝒙) using the built-in function Math.Exp, or bycalculating the cubic Taylor series approximation: 𝟏 + 𝒙 + 𝟏𝟐 𝒙𝟐 + 𝟏𝟔 𝒙𝟑? Also compare thespeed of using the natural log function Math.Log
# Speed Comparison Experiments

## Experiment 1: Speed Comparison between Adding Floats and Doubles

**Objective:**
Assess the speed of adding two arrays containing floats and doubles, both generated using random numbers.

**Findings:**
- Addition of floats was observed to be faster than that of doubles, aligning with expectations.
- Float operations are generally faster than double operations on modern hardware due to lower precision (32-bit) but faster processing by the CPU.
- In scenarios where precision is not critical, adding floats is the superior choice in terms of speed.

## Experiment 2: Speed Comparison for Calculating Squares and Square Roots

**Objective:**
Examine three methods for calculating squares and square roots of an array of doubles: direct multiplication, Math.Pow, and Math.Sqrt.

**Observations:**
- Direct multiplication significantly outperforms Math.Pow and Math.Sqrt in square calculations due to its simplicity.
- Math.Pow exhibits the slowest performance in square calculations among the tested methods.
- Math.Sqrt, while slower than direct multiplication, is faster than Math.Pow in square calculations.
- For scenarios where precision is not critical and square calculations are required, direct multiplication is the optimal choice for speed.
- When computing square roots, Math.Sqrt is the preferred option, offering both speed and accuracy.

## Conclusion:

These experiments provide insights into the performance characteristics of float and double addition as well as methods for square and square root calculations. Consider these findings when choosing between precision and speed in your specific application scenarios.
