var vipGuests = new HashSet<string>();
var regularGuests = new HashSet<string>();

var input = Console.ReadLine();

while (input != "PARTY")
{
    var first = input[0];
    if (char.IsDigit(first))
    {
        vipGuests.Add(input);
    }
    else
    {
        regularGuests.Add(input);
    }
    input = Console.ReadLine();
}
input = Console.ReadLine();

while (input != "END")
{
    var first = input[0];
    if (char.IsDigit(first))
    {
        vipGuests.Remove(input);
    }
    else
    {
        regularGuests.Remove(input);
    }
    input = Console.ReadLine();
}

Console.WriteLine(vipGuests.Count + regularGuests.Count);

foreach (var item in vipGuests)
{
    Console.WriteLine(item);
}

foreach (var item in regularGuests)
{
    Console.WriteLine(item);
}

