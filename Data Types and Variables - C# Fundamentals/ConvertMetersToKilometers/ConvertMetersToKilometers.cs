internal class Program
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        double output = input / 1000.00;
        Console.WriteLine($"{output:F2}");
    }
}