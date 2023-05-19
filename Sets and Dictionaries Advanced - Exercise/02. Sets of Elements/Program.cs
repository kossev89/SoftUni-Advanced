var setSizes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var n = setSizes[0];
var m = setSizes[1];

var setN = new HashSet<int>();
var setM = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    var input = int.Parse(Console.ReadLine());
    setN.Add(input);
}
for (int i = 0; i < m; i++)
{
    var input = int.Parse(Console.ReadLine());
    setM.Add(input);
}

setN.IntersectWith(setM);
Console.WriteLine(string.Join(' ', setN));