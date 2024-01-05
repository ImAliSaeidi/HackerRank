namespace HackerRank.Contests;
public static class ProjectEuler
{
    public static long SumOfEvenFibonacciNumberLessThanInput(this long input)
    {
        var result = 0L;
        var previous = 2;
        var current = 8;

        while (current < input)
        {
            result += current;
            var next = 4 * current + previous;
            previous = current;
            current = next;
        }

        return result + 2;
    }

    public static long FindLargestPrimeFactor(this long input)
    {
        long factor = 2;

        while (factor * factor <= input)
        {
            if (input % factor == 0)
            {
                input /= factor;
            }
            else
            {
                factor++;
            }
        }

        return input;
    }

    public static long FindLargestPalindromicNumberLessThanInput(this long input)
    {
        long largestPalindrome = 0;

        for (int i = 999; i >= 100; i--)
        {
            for (int j = i; j >= 100; j--)
            {
                long product = i * j;

                if (product < input && product.IsPalindromic() && product > largestPalindrome)
                {
                    largestPalindrome = product;
                }
            }
        }

        return largestPalindrome;
    }

    private static bool IsPalindromic(this long input)
    {
        var inputStr = input.ToString();
        var left = 0;
        var right = inputStr.Length - 1;

        while (left < right)
        {
            if (inputStr[left] != inputStr[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    public static long SmallestMultiple(this long input)
    {
        var result = 1L;

        for (long i = 2; i <= input; i++)
        {
            result = LCM(result, i);
        }

        return result;
    }

    private static long GCD(long firstInput, long secondInput)
    {
        while (secondInput != 0)
        {
            var temp = secondInput;
            secondInput = firstInput % secondInput;
            firstInput = temp;
        }

        return firstInput;
    }

    private static long LCM(long firstInput, long secondInput)
    {
        return Math.Abs(firstInput * secondInput) / GCD(firstInput, secondInput);
    }

    public static long SumSquareDifference(this long input)
    {
        var sumOfSquares = 0L;
        var sum = 0L;

        for (long i = 1; i <= input; i++)
        {
            sum += i;
            sumOfSquares += (long)Math.Pow(i, 2);
        }

        return (long)Math.Abs(sumOfSquares - Math.Pow(sum, 2));
    }

    public static long FindThePrimeNumberWithGivenIndex(this long input)
    {
        if (input == 1)
            return 2;

        var index = 2;
        var candidate = 3L;

        while (index < input + 1)
        {
            if (candidate.IsPrime())
                index++;

            if (index < input + 1)
                candidate += 2;
        }

        return candidate;
    }

    private static bool IsPrime(this long input)
    {
        if (input < 2)
            return false;

        var sqr = (int)Math.Sqrt(input);
        if (sqr * sqr == input)
            return false;

        for (int i = 2; i < Math.Sqrt(input); i++)
        {
            if (input % i == 0)
                return false;
        }

        return true;
    }
}
