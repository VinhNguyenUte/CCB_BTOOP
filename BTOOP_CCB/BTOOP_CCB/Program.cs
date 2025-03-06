using BTOOP_CCB;

internal class Program
{
    public static void Main(string[] args)
    {
        IEmployee employee1 = new PartTimeEmployee("Trung", 45000, 7);
        Console.WriteLine("Name: " + employee1.GetName());
        Console.WriteLine("Salary per day: " + employee1.CalculateSalary());

        IEmployee employee2 = new FullTimeEmployee("Linh", 65000);
        Console.WriteLine("Name: " + employee2.GetName());
        Console.WriteLine("Salary per day: " + employee2.CalculateSalary());
        Console.ReadKey();
    }
}