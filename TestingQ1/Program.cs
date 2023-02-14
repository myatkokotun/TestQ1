List<int> fizzlist = new List<int>();
List<int> buzzlist = new List<int>();
List<int> fizzbuzzlist = new List<int>();
List<int> nonlist = new List<int>();
int value = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        fizzbuzzlist.Add(i);
    }
    else if (i % 3 == 0)
    {
        fizzlist.Add(i);
    }
    else if (i % 5 == 0)
    {
        buzzlist.Add(i);
    }
    else
    {
        nonlist.Add(i);
    }
}
Console.WriteLine("Fizz :" + string.Join(" ", fizzlist));
Console.WriteLine("Buzz :" + string.Join(" ", buzzlist));
Console.WriteLine("Fizzbuzz :" + string.Join(" ", fizzbuzzlist));
Console.WriteLine("Non :" + string.Join(" ", nonlist));
Console.WriteLine("Please enter a number between 1 and 100 :");
var input = Console.ReadLine();
value = Convert.ToInt32(input);
if (value % 15 == 0)
{
    Console.WriteLine(value + " is Fizzbuzz");
}
else if (value % 3 == 0)
{
    Console.WriteLine(value + " is Fizz");
}
else if (value % 5 == 0)
{
    Console.WriteLine(value + " is Buzz");
}
else
{
    Console.WriteLine(value + " is non of them");
}
