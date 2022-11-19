class Program
{
    public static double Compute(Sequence info, int count )
    {
        return info.Sum(count)/count;

    }

public static void Main(string[] args)
{
    int n = int.Parse(args[0]);

    var a = new LinearSequence(3.0,6.0);
    var b = new PowerSequence(2.0);
    Console.WriteLine("First Linear Sequence Computation result = {0.00}",Program.Compute(a,n));
    Console.WriteLine("Second Linear Sequence Computation result = {0.00}",Program.Compute(a,n));
    Console.WriteLine(" First Power Sequence Computation result = %f%n",Program.Compute(b,n));
    Console.WriteLine(" Second Power Sequence Computation result = %f%n",Program.Compute(b,n));





}

}