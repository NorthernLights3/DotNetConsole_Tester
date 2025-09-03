// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// reverse a string.
const string str = "Hello, World!";

string ReverseString(string s)
{
    char[] charArray = s.ToArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

Console.WriteLine(ReverseString(str));

int[] numbers = [1, 2, 3, 4, 5, 7, 9, 25, 44, 1023, 212, 12, 11, 1, 0, -50, -5000, 44, 32, 21, 15];


NumObj FindLargestOccurance()
{
    var lookup = new Dictionary<int, NumObj>();
    foreach (var num in numbers)
    {
        if (!lookup.ContainsKey(num))
        {
            lookup[num] = new NumObj { Number = num, Occurances = 0 };
        }

        lookup[num].Occurances++;
    }

    var highest = lookup.Values.OrderByDescending(o => o.Occurances);
    Console.WriteLine($"Highest occurance is {highest.First().Occurances}");

    return highest.Where(o => o.Occurances == highest.First().Occurances).OrderByDescending(o => o.Number).First();
}

var obj = FindLargestOccurance();
Console.WriteLine($"Number {obj.Number} occurs {obj.Occurances} times.");

var results = await Fabricator.GetProductsAsync();
Console.WriteLine(string.Join(Environment.NewLine, results.Select(p => p.Name)));