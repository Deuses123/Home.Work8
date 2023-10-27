namespace Home.Work8;

public class Program
{
    public static void Main(string[] args)
    {
        //Task1
        var arr = new SquaredArray(5)
        {
            [0] = 1,
            [2] = 2,
            [3] = 3,
            [4] = 4,
        };

        Console.WriteLine(arr);
        
        // Task 2
        Console.WriteLine("Задача вторая");
        var calculator = new PaymentCalculator(20.0, 300.0, 130.0, 19.0);
        var house = new House(100.0,3, true, false,true, false);
        house.calculate(calculator);
        
    }
}