namespace f_fizzbuzz_app;

public class Fizzbuzz
{
    private readonly int _endNumber = 100;

    public string[] GetSequence()
    {
        // var numbers = new List<int>();
        var fizzBuzzArray = new string [_endNumber];
        for (var i = 0; i < _endNumber; i++)
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

    public void PrintSequence()
    {
        foreach (var element in GetSequence())
        {
            Console.Write($"{element} ");
        }
    }
}