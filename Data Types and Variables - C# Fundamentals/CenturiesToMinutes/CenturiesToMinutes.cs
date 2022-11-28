namespace CenturiesToMinutes
{
    internal class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            double centuries = int.Parse(Console.ReadLine());

            double years = centuries * 100;
            double days = Math.Round(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            string output = $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes";

            Console.WriteLine(output);  
        }
    }
}