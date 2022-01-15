namespace Lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FibonacciSequenceService.PrintFibonacciSequence1(10);
            FibonacciSequenceService.PrintFibonacciSequence2(10);
            FibonacciSequenceService.PrintFibonacciSequence3(10);

            FibonacciSequenceService.PrintFibonacciSequence1(-10);
            FibonacciSequenceService.PrintFibonacciSequence2(-10);
            FibonacciSequenceService.PrintFibonacciSequence3(-10);

            FibonacciSequenceService.PrintFibonacciSequence1(10000);
            FibonacciSequenceService.PrintFibonacciSequence2(10000);
            FibonacciSequenceService.PrintFibonacciSequence3(10000);

            FactorialService.GetPossibleFactorial(5);

            FactorialService.GetPossibleFactorial(-5);

            FactorialService.GetPossibleFactorial(10000);
        }
    }
}