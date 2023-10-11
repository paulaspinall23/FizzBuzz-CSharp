namespace FizzBuzz;

internal class Program
{
    static void Fizzbuzz()
    {
        Console.WriteLine("Which numbers would you like to create rules for? (separate each number with a ,): ");
        string numberInput = Console.ReadLine()!;
        
        int[] numbers = numberInput.Split(new[] {','}, 
            StringSplitOptions.RemoveEmptyEntries).Select(numberInput => 
            Convert.ToInt32(numberInput)).ToArray();
        
        Console.WriteLine("Which {0} words would you like to add to the numbers? (separate each number with a ,): ", numbers.Length);
        string wordInput = Console.ReadLine()!.Replace(" ", "");

        String[] words = wordInput.Split(',');
        
        Dictionary<int, string> fbWords = new Dictionary<int, string>();

        for (int i = 0; i < numbers.Length; i++)
        {
            fbWords.Add(numbers[i], words[i]);
        }         

        Console.Write("Please enter a maximum number: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        List<string> result = new List<string>();

        for (int i = 1; i <= choice; i++)
        {
            result.Clear();

            foreach (int item in fbWords.Keys)
            {
                if (IsDivisibleBy(i, item))
                {
                    result.Add(fbWords[item]);
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
        Fizzbuzz();
    }
}