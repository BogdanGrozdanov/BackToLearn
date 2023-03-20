namespace Grades
{
    internal class Grades
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);
        }

        static void Grade(double grade)
        {
            if      (grade >= 5.50 && grade <= 6.00) { Console.WriteLine("Excellent"); }
            else if (grade >= 4.50 && grade <= 5.49) { Console.WriteLine("Veery good"); }
            else if (grade >= 3.50 && grade <= 4.49) { Console.WriteLine("Good"); }
            else if (grade >= 3.00 && grade <= 3.49) { Console.WriteLine("Poor"); }
            else if (grade >=2.00 && grade <= 2.99) { Console.WriteLine("Fail"); }
        }
    }
}