//namespace math;
class Program 
{
    public static void Main(string[] args)
    {
        int nu = int.Parse(args[0]);
        int mu = int.Parse(args[1]);
        if(MathUtil.IsEven(nu))
        Console.WriteLine("The NO. is Even {0} ",nu);
        else
        Console.WriteLine("The NO. is not even {0}",nu);
        
        if(MathUtil.IsOdd(nu))
        Console.WriteLine("The NO. is Odd {0} ",nu);
        else
        Console.WriteLine("The NO. is not Odd{0} ",nu);

        if(MathUtil.IsPrime(nu))
        Console.WriteLine("The NO. is prime {0} ",nu);
        else
        Console.WriteLine("The NO. is not prime {0} ",nu);
        
                
        Console.WriteLine("Prime numbers Between {0} and {1} is {2}",nu,mu,MathUtil.CountPrime(nu,mu));
        Console.WriteLine("Reverse of a given number {0} is {1}",nu,MathUtil.Reverse(nu));
        Console.WriteLine("Digitcount of a given number {0} is {1}",nu,MathUtil.DigitCount(nu));

      }
}