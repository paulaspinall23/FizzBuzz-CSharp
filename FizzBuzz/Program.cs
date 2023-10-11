namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz(string[] args)
    {
        List<int> userEntry = new List<int>();

        foreach (string entry in args)
        {
            userEntry.Add(Convert.ToInt32(entry));
        }

        Console.Write("Please enter a maximum number: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, string> fbWords = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"},
            {7, "Bang"},
            {11, "Bong"},
            {13, "Fezz"}
        };

        List<string> result = new List<string>();

        for (int i = 1; i <= choice; i++)
        {
            result.Clear();

            foreach (int item in userEntry)
            {
                if (item != 11 && item != 13 && item != 17)
                {
                    if (IsDivisibleBy(i, item))
                    {
                        result.Add(fbWords[item]);
                    }
                }
                if (item == 11)
                {
                    if (IsDivisibleBy(i, 11))
                    {
                        result.Clear();
                        result.Add("Bong");
                    }
                }
                if (item == 13)
                {
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
                }
                if (item == 17)
                {
                    if (IsDivisibleBy(i, 17))
                    {
                        result.Reverse();
                    }
                }
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
        Fizzbuzz(args);
    }
}