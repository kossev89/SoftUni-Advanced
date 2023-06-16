using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount { get => Registry.Count; }

        public bool AddChild(Child child)
        {
            bool childAdded = false;
            if (Capacity > Registry.Count)
            {
                Registry.Add(child);
                childAdded = true;
            }
            return childAdded;
        }

        public bool RemoveChild(string childFullName)
        {
            bool childRemoved = false;
            string[] names = childFullName
                .Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in Registry)
            {
                if (item.FirstName == names[0] && item.LastName == names[1])
                {
                    childRemoved = true;
                    Registry.Remove(item);
                    break;
                }
            }
            return childRemoved;
        }


        public string GetChild(string childFullName)
        {
            Child result = default;
            string[] names = childFullName
                .Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in Registry)
            {
                if (item.FirstName == names[0] && item.LastName == names[1])
                {
                    result = item;
                    break;
                }

            }
            if (result == default)
            {
                return null;
            }
            else
            {
                return result.ToString();
            }
        }

        public string RegistryReport()
        {
            StringBuilder report = new();
            var registrySorted = Registry.OrderByDescending(x => x.Age)
                .ThenBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .ToList();
            report.AppendLine($"Registered children in {Name}:");
            foreach (var item in registrySorted)
            {
                report.AppendLine(item.ToString());
            }
            return report.ToString().Trim();
        }


    }
}
