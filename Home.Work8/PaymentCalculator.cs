namespace Home.Work8;

public class PaymentCalculator
{
    private double heatingRate;
    private double waterRate;
    private double gasRate;
    private double repairRate;

    
    public PaymentCalculator(double heatingRate, double waterRate, double gasRate, double repairRate)
    {
        this.heatingRate = heatingRate;
        this.waterRate = waterRate;
        this.gasRate = gasRate;
        this.repairRate = repairRate;
    }

    public double CalculateHeatingCost(double area, bool isWinter, bool isAutumn)
    {
        var heatingCost = heatingRate * area;
        if (isWinter)
        {
            heatingCost *= 1.5; // Зимой отопление дороже
        }
        else if (isAutumn)
        {
            heatingCost *= 1.2; //Зима не осень жить можно и с 20%
        }
        return heatingCost;
    }

    public double CalculateWaterCost(int residents)
    {
        return waterRate * residents;
    }

    public double CalculateGasCost(int residents)
    {
        return gasRate * residents;
    }

    public double CalculateRepairCost(double area)
    {
        return repairRate * area;
    }
}