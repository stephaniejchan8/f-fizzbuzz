using f_fizzbuzz_app;

namespace f_fizzbuzz_tests;

// Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”."

public class FizzbuzzTests
{
    Fizzbuzz fizzbuzz = new Fizzbuzz();

    // [Fact]
    // public void GetSequence_ShouldReturn1to20()
    // {
    //     // ARRANGE 
    //     var expected = new int [20]
    //     {
    //         1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
    //     }; // change this to .length for next test to count number of items in list?
    //
    //     // ACT
    //     var actual = fizzbuzz.GetSequence();
    //
    //     // ASSERT
    //     Assert.Equal(expected, actual);
    // }

    [Fact]
    public void GetSequence_ShouldReturnFizzbuzzOnMultiplesOf15()
    {
        // ARRANGE 
        var expected = "FizzBuzz";


        // ACT
        var actual = fizzbuzz.GetSequence()[14];

        // ASSERT
        Assert.Equal(expected, actual);
    }
}