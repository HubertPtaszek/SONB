namespace Lab5
{
    public class FactorialService
    {
        public static long GetFactorial1(int n)
        {
            if (n > 0)
            {
                if (n == 1)
                    return 1;
                else
                    return n * GetFactorial1(n - 1);
            }
            else
            {
                Console.WriteLine("number has to be positive ");
                return 0;
            }
        }

        public static long GetFactorial2(int n)
        {
            int result = 1;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("number has to be positive ");
                return -1;
            }
            Console.WriteLine($"Factorial 2 for n={n}: {result}");
            return (long)result;
        }

        public static long GetFactorial3(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial 3 for n={n}: {result}");
            return ((long)result);
        }

        public static void GetPossibleFactorial(int n)
        {
            long r1 = GetFactorial1(n);
            if (n > 0)
            {
                Console.WriteLine($"Factorial 1 for n={n}: {r1}");
            }

            long r2 = GetFactorial2(n);
            long r3 = GetFactorial3(n);
            if (r1 == r2 && r2 == r3 & r1 == r3)
            {
                Console.WriteLine($"Most possible factorial: {r1}");
            }
            else if (r1 == r2)
            {
                Console.WriteLine($"Most possible factorial: {r1}");
            }
            else if (r2 == r3)
            {
                Console.WriteLine($"Most possible factorial: {r2}");
            }
            else if (r1 == r3)
            {
                Console.WriteLine($"Most possible factorial: {r1}");
            }
            else
            {
                Console.WriteLine($"Something goes wrong");
            }
        }
    }
}