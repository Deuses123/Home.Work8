namespace Home.Work8;

public class House
{
    public double Area { get; set; }
    public int Residents { get; set; }
    public bool IsWinter { get; set; }
    public bool IsAutumn { get; set; }
    public bool IsLaborVeteran { get; set; }
    public bool IsWarVeteran { get; set; }

    public House(double area, int residents, bool isWinter, bool isAutumn, bool isLaborVeteran, bool isWarVeteran)
    {
        if(!isWinter)
            IsAutumn = isAutumn;
        Area = area;
        Residents = residents;
        if(!isAutumn)
            IsWinter = isWinter;
        IsLaborVeteran = isLaborVeteran;
        IsWarVeteran = isWarVeteran;
    }

    public void calculate(PaymentCalculator calculator)
    {
        double benefitCoefficient = 1.0;
        if (IsLaborVeteran) benefitCoefficient = 0.7;
        else if (IsWarVeteran) benefitCoefficient = 0.5;
        
        var heatingCost = calculator.CalculateHeatingCost(Area, IsWinter, IsAutumn);
        var waterCost = calculator.CalculateWaterCost(Residents);
        var gasCost = calculator.CalculateGasCost(Residents);
        var repairCost = calculator.CalculateRepairCost(Area);

        var totalCost = (heatingCost + waterCost + gasCost + repairCost) * benefitCoefficient;
        

        Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
        Console.WriteLine($"Отопление\t{heatingCost}\t\t{heatingCost - heatingCost*benefitCoefficient}\t\t{heatingCost*benefitCoefficient}");
        Console.WriteLine($"Вода\t\t{waterCost}\t\t{waterCost - waterCost * benefitCoefficient}\t\t{waterCost * benefitCoefficient}");
        Console.WriteLine($"Газ\t\t{gasCost}\t\t{gasCost - gasCost * benefitCoefficient}\t\t{gasCost * benefitCoefficient}");
        Console.WriteLine($"Ремонт\t\t{repairCost}\t\t{repairCost - repairCost * benefitCoefficient}\t\t{benefitCoefficient*repairCost}");
        Console.WriteLine($"Итого\t\t{totalCost}");
    }
}