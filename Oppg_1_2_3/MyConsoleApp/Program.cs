
public partial class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new calculator();
        Console.WriteLine(calculator.Add(4, 4));
        Console.WriteLine(calculator.Substract(10, 4));
    }
}
