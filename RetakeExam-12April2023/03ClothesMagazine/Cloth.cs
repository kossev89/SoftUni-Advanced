﻿using System;
using System.Drawing;
using System.Text;

namespace ClothesMagazine
{
    public class Cloth
    {
        public Cloth (string color, int size, string type)
        {
            Color = color;
            Size = size;
            Type = type;
        }

        public string Color { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            StringBuilder output = new();
            output.AppendLine($"Product: {Type} with size {Size}, color {Color}");
            return output.ToString().Trim();
        }
    }
}
