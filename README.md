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
