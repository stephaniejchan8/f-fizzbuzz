namespace f_fizzbuzz_app;

public class Fizzbuzz
{
    public int SequenceSize { get; set; }
    
    public string[] GetSequence()
    {
        var fizzBuzzArray = new string [SequenceSize];
        for (var i = 0; i < SequenceSize; i++)
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
                fizzBuzzArray[i] = $"{i + 1}";
            }
        }
        return fizzBuzzArray;
    }
}