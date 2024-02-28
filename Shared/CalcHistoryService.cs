namespace Shared;

public class CalcHistoryService
{
    public List<Calculation> Calculations { get; set; } = new List<Calculation>();

    public List<Calculation> GetAllCalculations()
    {
        return Calculations;
    }

    public void AddCalculation(Calculation calculation)
    {
        Calculations.Add(calculation);
    }
}