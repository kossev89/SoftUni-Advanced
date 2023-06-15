using System;

namespace SoftUniKindergarten
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Kindergarten kindergarten = new Kindergarten("Space S", 3);
            Child childOne = new Child("Ruzha", "Garbo", 6, "Karl Gustafsson", "0468 888 888");
            Child childTwo = new Child("Ruzha", "Muskova", 6, "Maye Musk", " 1 888 518 3752");
            Child childThree = new Child("George", "Bush", 5, " George Bush Sr.", "xx xxx xxx xxx");
            Child childFour = new Child("Ruzha", "Ignatova", 6, "Veska Ignatova", "+49 30 901820");
            Child childFive = new Child("Greta", "Thinberg", 3, "Allen White", "541-754-3010");
            Child childSix = new Child("T", "Rex", 2, "Steven Spielberg", "63 001 09 93");
            Child childSeven = new Child("S", "Rex", 2, " Steven Spielberg ", "63 001 09 93");
            Child childEight = new Child("Greta", "Thunberg", 3, "Pablo Gaviria", "0888 888 888");
            Child childNine = new Child("Tim", "Duncan", 6, "William Duncan", "(555) 555-1234");
            Console.WriteLine(kindergarten.AddChild(childOne));
            Console.WriteLine(kindergarten.AddChild(childTwo));
            Console.WriteLine(kindergarten.AddChild(childThree));
            Console.WriteLine(kindergarten.AddChild(childFour));
            Console.WriteLine(kindergarten.RemoveChild("George Bush"));
            Console.WriteLine(kindergarten.AddChild(childFour));
            Console.WriteLine(kindergarten.RegistryReport());
            Console.WriteLine(kindergarten.GetChild("Ruzha Ignatova"));
            Console.WriteLine(kindergarten.GetChild("Ruzha Igdsad"));
        }
    }
}
