namespace f_fizzbuzz_app;

public class Fizzbuzz
{
    // public int SequenceSize { get; set; }

    // Experimenting with constructors:
    // public Fizzbuzz(int sequenceSize)sequenceSize = sequenceSize;
    // }
    //
    // public Fizzbuzz()
    // {
    // }
    public string[] GetSequence(int sequenceSize)
    {
        var fizzBuzzArray = new string [sequenceSize];
        for (var i = 0; i < sequenceSize; i++)
        {
            var currentNumber = i + 1;
            
            if (currentNumber % 15 == 0)
            {
                fizzBuzzArray[i] = "FizzBuzz";
            } else if (currentNumber % 5 == 0)
            {
                fizzBuzzArray[i] = "Buzz";
            } else if (currentNumber % 3 == 0)
            {
                fizzBuzzArray[i] = "Fizz";
            }
            else
            {
                fizzBuzzArray[i] = $"{currentNumber}";
            }
        }
        return fizzBuzzArray;
    }
}