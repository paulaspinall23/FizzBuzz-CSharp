namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        List<string> result = new List<string>();

        for (int i = 1; i < 300; i++)
        {
            result.Clear();
            if (IsDivisibleBy(i, 3))
            {
                result.Add("Fizz");
            }
            if (IsDivisibleBy(i, 5))
            {
                result.Add("Buzz");
            }
            if (IsDivisibleBy(i, 7))
            {
                result.Add("Bang");
            }
            if (IsDivisibleBy(i, 11))
            {
                result.Clear();
                result.Add("Bong");
            }
            if (IsDivisibleBy(i, 13))
            {
                if (result.Contains("Fizz"))
                {
                    int index = result.IndexOf("Fizz");
                    result.Insert(index+1, "Fezz");
                }
                else
                {
                    result.Insert(0, "Fezz");
                }
            }
            if (IsDivisibleBy(i, 17))
            {
                result.Reverse();
            }
            if (result.Count == 0)
            {
                result.Add(i.ToString());
            }
            Console.WriteLine(string.Join("",result));
        }
    }
    private static bool IsDivisibleBy(int numerator, int denominator)
    {
        return numerator % denominator == 0;
    }
    
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
}