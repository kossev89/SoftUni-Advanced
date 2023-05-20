var command = Console.ReadLine();
var parkLot = new HashSet<string>();

while (command != "END")
{
    var tokens = command
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    var direction = tokens[0];
    var carNumber = tokens[1];

    switch (direction)
    {
        case "IN":
            parkLot.Add(carNumber); break;
        case "OUT":
            parkLot.Remove(carNumber); break;

        default:
            break;
    }
    command = Console.ReadLine();
}
if (parkLot.Count > 0)
{
    foreach (var car in parkLot)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}