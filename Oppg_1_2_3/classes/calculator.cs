using System.Threading.Tasks.Dataflow;
public class calculator : ICalculator 
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Substract(double a, double b)
    {
        return a - b;
    }
}