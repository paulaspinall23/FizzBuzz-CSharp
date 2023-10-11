namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        Console.Write("Please enter a maximum number: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        List<string> result = new List<string>();

        for (int i = 1; i <= choice; i++)
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
                bool didAddFezz = false;

                for (int j = 0; j < result.Count; j++)
                {
                    string currentword = result[j];
                    if (currentword[0] == 'B' || currentword[0] == 'b')
                    {
                        result.Insert(j, "Fezz");
                        didAddFezz = true;
                        break;
                    }
                }
                if (!didAddFezz)
                {
                    result.Add("Fezz");
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