//namespace math;
class MathUtil
{    public static bool IsEven(int a)
    {
        if (a % 2 == 0)
            return true;
        return false;
    }

    public static bool IsOdd(int b)
    {
        if (b % 2 != 0)
            return true;
        return false;
    }

    public static bool IsPrime(int c)
    {
        if (c == 1)
            return false;
        if (c == 2 || c == 3)
            return true;

        for (int m = 2; m * m <= c; ++m)
        {
        if (c % m == 0)
        return false;
        }
        return true;
    }
   
    public static int CountPrime(int d, int e)
    {
        int count = 0;
        for (int i = d; i <= e; ++i)
        {
            if (IsPrime(i))
                count++;
        }
        return count;
    }

    public static int Reverse(int f)
    {
        int reverse = 0;
        int rem = 0;
        while (f != 0)
        {
            rem = f % 10;
            reverse = reverse * 10 + rem;
            f = f / 10;
        }

        return reverse;
    }

    public static int DigitCount(int g)
    {
        int count = 0;
        while (g != 0)
        {
            g /= 10;
            count++;
        }
        return count;
    }
}