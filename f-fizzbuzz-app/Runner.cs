namespace f_fizzbuzz_app;

public class Runner
{
    public void RunFizzbuzz()
    {
        var fizzbuzz = new Fizzbuzz();

        var inputtedSequenceSize = RequestSizeOfSequence();
        while (!IsValidSize((inputtedSequenceSize)))
        {
            Console.WriteLine("Please enter the number of elements you would like to print.");
            inputtedSequenceSize = RequestSizeOfSequence();
        }

        var sequenceSize = Int32.Parse(inputtedSequenceSize);
        var fizzBuzzArray = fizzbuzz.GetSequence(sequenceSize);
        PrintSequence(fizzBuzzArray);
    }

    private static string RequestSizeOfSequence()
    {
        Console.WriteLine("How many elements would you like to FizzBuzz?");
        return Console.ReadLine();
    }

    private static bool IsValidSize(string userInput)
    {
        return int.TryParse(userInput, out _);

        // if (int.TryParse(sequenceSizeString, out var sequenceSize))
        //     {
        //         return sequenceSize;
        //     }
        //     return 0;
    }

    private static void PrintSequence(string[] array)
    {
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
    }
}