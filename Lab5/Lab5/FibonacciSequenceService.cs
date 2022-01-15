namespace Lab5
{
    public class FibonacciSequenceService
    {
        public static void PrintFibonacciSequence1(int n)
        {
            int num1 = 0, num2 = 1, counter = 0;
            Console.WriteLine($"Fibonacci 1 for n={n}: ");
            while (counter < n)
            {
                Console.Write($"{num1} ");
                int num3 = num2 + num1;
                num1 = num2;
                num2 = num3;
                ++counter;
            }
        }

        public static void PrintFibonacciSequence2(int n)
        {
            Console.WriteLine($"Fibonacci 2 for n={n}: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{Fib2(i)} ");
            }
        }

        private static int Fib2(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            int prevPrev = 0, prev = 1, currentNumber = 0;
            for (int i = 2; i < n; i++)
            {
                currentNumber = prevPrev + prev;
                prevPrev = prev;
                prev = currentNumber;
            }
            return currentNumber;
        }

        public static void PrintFibonacciSequence3(int n)
        {
            Console.WriteLine($"Fibonacci 3 for n={n}: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Fib3(i)} ");
            }
        }

        private static int Fib3(int n)
        {
            int[] fibSeq = new int[n + 2];
            fibSeq[0] = 0;
            fibSeq[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
            }
            return fibSeq[n];
        }
    }
}