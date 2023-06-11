using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            bool removed = false;
            foreach (var item in Clothes)
            {
                if (item.Color == color)
                {
                    Clothes.Remove(item);
                    removed = true;
                    break;
                }
            }
            return removed;
        }

        public Cloth GetSmallestCloth()
        {
            Cloth smallestCloth = Clothes[0];
            foreach (var item in Clothes)
            {
                if (item.Size < smallestCloth.Size)
                {
                    smallestCloth=item;
                }
            }
            return smallestCloth;
        }

        public Cloth GetCloth(string color)
        {
            Cloth cloth = default;
            foreach (var item in Clothes)
            {
                if (item.Color==color)
                {
                    cloth = item;
                    break;
                }
            }
            return cloth;
        }
        public int GetClothCount()
        {
            int count = Clothes.Count;
            return count;
        }
        public string Report()
        {
            Clothes = Clothes.OrderBy(x => x.Size).ToList();
            StringBuilder report = new();
            report.AppendLine($"{Type} magazine contains:");
            foreach (var item in Clothes)
            {
                report.AppendLine(item.ToString());
            }
            return report.ToString().Trim();
        }
    }
}
