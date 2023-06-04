using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Cargo
    {
		private string type;
		private int weight;

		public Cargo(string type, int weight)
		{
			Type = type;
			Weight = weight;
		}

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}


		public string Type
		{
			get { return type; }
			set { type = value; }
		}

	}
}
