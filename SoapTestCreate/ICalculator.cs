using System.ServiceModel;

[ServiceContract]
public interface ICalculator
{
    [OperationContract]
    string Add(int a, int b);
}

public class CalculatorService : ICalculator
{
    public string Add(int a, int b)
    {
        return "Ramazan Kucukkoc";
    }
}
