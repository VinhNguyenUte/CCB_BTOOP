using BTOOP_CCB;

internal class Program
{
    public static void Main(string[] args)
    {
        IEmployee BIEN_2233_1 = new PartTimeEmployee("HUYNH NGUYEN VINH NGUYEN - 2233 PART TIME", 45000, 7);
        Console.WriteLine("Name: " + BIEN_2233_1.GetName());
        Console.WriteLine("Salary per day: " + BIEN_2233_1.CalculateSalary());

        IEmployee BIEN_2233_2 = new FullTimeEmployee("HUYNH NGUYEN VINH NGUYEN - 2233 FULL TIME", 65000);
        Console.WriteLine("Name: " + BIEN_2233_2.GetName());
        Console.WriteLine("Salary per day: " + BIEN_2233_2.CalculateSalary());
        Console.ReadKey();
    }
}