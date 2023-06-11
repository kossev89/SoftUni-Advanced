using System;

namespace ClothesMagazine
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("Zara", 1);
            Cloth cloth1 = new Cloth("red", 36, "dress");
            magazine.AddCloth(cloth1);
            Console.WriteLine(magazine.RemoveCloth("red"));
            ;
        }
    }
}
