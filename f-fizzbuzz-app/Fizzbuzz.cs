namespace f_fizzbuzz_app;

public class Fizzbuzz
{
    private readonly int _endNumber = 20;

    public string[] GetSequence()
    {
        // var numbers = new List<int>();
        var fizzBuzzArray = new string [20];
        for (var i = 0; i < _endNumber; i++)
        {
            if ((i + 1) % 15 == 0)
            {
                fizzBuzzArray[i] = "FizzBuzz";
            }
            else
            {
                fizzBuzzArray[i] = $"{i + 1}";
            }
        }

        return fizzBuzzArray;
    }
}