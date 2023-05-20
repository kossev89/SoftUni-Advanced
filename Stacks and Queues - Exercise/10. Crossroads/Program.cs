var greenLight = int.Parse(Console.ReadLine());
var freeWindow = int.Parse(Console.ReadLine());
var carsQueue = new Queue<string>();

var command = Console.ReadLine();
var carsPassed = 0;
var isCrashed = false;

while (command != "END")
{
    switch (command)
    {
        case "green":
            var timeGreen = greenLight;
            var timeFree = freeWindow;

            while (timeGreen > 0 && carsQueue.Count > 0)
            {
                var currentCar = carsQueue.Peek();
                if ((timeGreen + timeFree) >= currentCar.Length)
                {
                    timeGreen -= currentCar.Length;
                    carsQueue.Dequeue();
                    carsPassed++;
                }
                else
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentCar[timeGreen + timeFree]}");
                    isCrashed = true;
                    break;
                }
            }
            break;
        default:
            carsQueue.Enqueue(command);
            break;
    }
    if (isCrashed == true)
    {
        break;
    }
    else
    {
        command = Console.ReadLine();
    }
}
if (isCrashed == false)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
}
