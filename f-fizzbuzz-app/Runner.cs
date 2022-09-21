namespace f_fizzbuzz_app;

public static class Runner
{
    public static void Run()
    {
        var fizzbuzz = new Fizzbuzz();
        
        var inputtedSequenceSize = RequestSizeOfSequence();
        
        if (inputtedSequenceSize != 0)
        {
            fizzbuzz.SequenceSize = inputtedSequenceSize;
            var fizzBuzzArray = fizzbuzz.GetSequence();
            PrintSequence(fizzBuzzArray);
        }
        else
        {
            Console.WriteLine("Please enter a number of elements you would like to print.");
        }
    }

    private static int RequestSizeOfSequence()
    {
        Console.WriteLine("How many elements would you like to FizzBuzz?");
        var sequenceSizeString = Console.ReadLine();

        int sequenceSize;
        int.TryParse(sequenceSizeString, out sequenceSize);
        
        return sequenceSize;
    }

    private static void PrintSequence(string[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
    }
}