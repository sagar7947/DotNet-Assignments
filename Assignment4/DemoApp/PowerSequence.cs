class PowerSequence: Sequence,Resetable
{
private double current;
private double factor;

public PowerSequence(double ratio)
{
    current = 1;
    factor = ratio;
}

    public override double Next()
    {
        double term = current;
        current*= factor;
        return term;
    }
    public void Reset()
    {
        current = 1;
    }

}