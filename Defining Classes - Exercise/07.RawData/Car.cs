using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
	public class Car
	{
		public Car(string model,
			int speed,
			int power,
			int weight,
			string type,
			int tireAge1,
			float tirePress1,
			int tireAge2,
			float tirePress2,
			int tireAge3,
			float tirePress3,
			int tireAge4,
			float tirePress4)
		{
			Model = model;
			Engine = new(speed, power);
			cargo = new(type, weight);
			Tires = new Tire[4];
			Tires[0] = new(tireAge1, tirePress1);
			Tires[1] = new(tireAge2, tirePress2);
			Tires[2] = new(tireAge3, tirePress3);
			Tires[3] = new(tireAge4, tirePress4);
		}

		public string Model { get; set; }
		public Engine Engine { get; set;}
		public Cargo cargo { get; set; }
		public Tire[] Tires { get; set; }

    }
}
