namespace AoC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            Day1v2 day1v2 = new Day1v2();
            Day2 day2 = new Day2();
            Day2v2 day2v2 = new Day2v2();

            day2v2.Run();
            System.Console.ReadKey();
        }
    }
}