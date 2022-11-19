class LinearSequence: Sequence
{
    private double current;
    private double step;
    
    public LinearSequence(double first, double difference)
    {
        current = first;
        step = difference;
    }
    public override double Next()
    {
        double term = current;
        current+= step;
       return term;
    }



}