var command = Console.ReadLine();
var shops = new Dictionary<string, Dictionary<string, double>>();

while (command != "Revision")
{
    var tokens = command.Split(", ");
    var shop = tokens[0];
    var product = tokens[1];
    var price = double.Parse(tokens[2]);

    if (shops.ContainsKey(shop))
    {
        if (shops[shop].ContainsKey(product))
        {
            shops[shop].Add(product, price);
        }
        else
        {
            shops[shop][product] = price;
        } 
    }
    else 
    {
        shops.Add(shop, new Dictionary<string, double>());
        if (shops[shop].ContainsKey(product))
        {
            shops[shop].Add(product, price);
        }
        else
        {
            shops[shop][product] = price;
        }
    }
    command = Console.ReadLine();
}

var sorted = shops.OrderBy(x => x.Key);

foreach (var shop in sorted)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}