using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Shoes = new();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<Shoe> Shoes { get; set; }
        public int Count { get { return Shoes.Count; } }
        IReadOnlyCollection<Shoe> shoes => shoes;

        public string AddShoe(Shoe shoe)
        {
            StringBuilder stringBuilder = new();
            if (Capacity > Count)
            {
                Shoes.Add(shoe);

                return stringBuilder.AppendLine($"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.").ToString().Trim();
            }
            else
            {
                return stringBuilder.AppendLine("No more space in the storage room.").ToString().Trim();
            }
        }
        public int RemoveShoes(string material)
        {
            int removedCount = 0;
            for (int i = 0; i < Count; i++)
            {
                if (Shoes[i].Material == material)
                {
                    Shoes.Remove(Shoes[i]);
                    removedCount++;
                    i--;
                }
            }
            return removedCount;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> filtered = new();
            foreach (var item in Shoes)
            {
                if (item.Type == type.ToLower())
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }
        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.FirstOrDefault(x => x.Size == size);
            return shoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder output = new();
            List<Shoe> shoesFiltered = new();
            foreach (var item in Shoes)
            {
                if (item.Size==size && item.Type==type)
                {
                    shoesFiltered.Add(item);
                }
            }
            if (shoesFiltered.Any())
            {
                output.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var item in shoesFiltered)
                {
                    output.AppendLine(item.ToString());
                }
            }
            else
            {
                output.AppendLine("No matches found!");
            }
            return output.ToString().Trim();
        }
    }
}
